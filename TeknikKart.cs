using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;

namespace YazilimSinamaFinalProje
{
    public partial class TeknikKart : MaterialSkin.Controls.MaterialForm
    {
        /// <summary>
        /// Class içinde kullanilacak gerekli değişkenler oluşturuluyor.
        /// </summary>
        public static string connectionSource = Properties.Settings.Default.ScrumTaskBoardProjectConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        List<String> taskNames = new List<String>();
        RadioButton selectedRB;
        string eskiTaskAdi;
        public TeknikKart()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.BLACK);
        }
        /// <summary>
        /// teknik kart formu açıldığında çalışan method.
        /// <summary>
        private void TeknikKart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'scrumTaskBoardProjectDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter.Fill(this.scrumTaskBoardProjectDataSet.tblUsers);
            // TODO: This line of code loads data into the 'scrumTaskBoardProjectDataSet.tblProjects' table. You can move, or remove it, as needed.
            this.tblProjectsTableAdapter.Fill(this.scrumTaskBoardProjectDataSet.tblProjects);
            //form ekranı ilk açıldığı zaman tarihi anlık tarih olarak ayarlıyor.
            lblTarih.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            //seçilmiş sabit radioButton'u ayarlıyor.
            selectedRB = rdoBtnYazilim;
            //listView'e veritabanındaki kartları listeliyor
            listViewListele();
        }
        /// <summary>
        /// veritabanında herhangi bir değişiklik sonrası listview'a yeni verileri listeleyen method.
        /// <summary>
        public void listViewListele()
        {
            listView1.Items.Clear();
            taskNames.Clear();
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM tblTaskStates TS, tblTasks T, tblStates S, tblProjects P, tblUsers U, tblSubstances ST " +
                        "WHERE TS.taskID = T.taskID AND TS.stateID = S.stateID AND TS.projectID = P.projectID AND TS.userID = U.userID AND TS.subsID = ST.subsID", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    //listView satırlarına veritabanındaki verileri yazdırıyor.
                    ListViewItem ekle = new ListViewItem();
                    ekle.Text = (read["taskID"].ToString());
                    DateTime createDt = Convert.ToDateTime(read["createDate"].ToString());
                    ekle.SubItems.Add(createDt.ToString("dd/MM/yyyy HH:mm"));
                    ekle.SubItems.Add(read["stateName"].ToString());
                    ekle.SubItems.Add(read["taskName"].ToString());
                    ekle.SubItems.Add(read["description"].ToString());
                    ekle.SubItems.Add(read["note"].ToString());
                    listView1.Items.Add(ekle);
                    taskNames.Add(read["taskName"].ToString());//kart adlarını güncelleme ve ekleme işlemlerinde kullanacağımız taskNames listesine ekliyor.
                }
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Hata: " + ex.ToString());

                throw;
            }
        }
        /// <summary>
        /// ekle butonuna tıklandığı an çalışan method.
        /// <summary>
        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (!textBoxIsEmpty())
            {
                //böyle bir isme sahip task var mı diye kontrol ediliyor.
                bool izin = true;
                foreach (String tskName in taskNames)
                {
                    if (tskName == txtBoxTaskAdi.Text)
                    {
                        izin = false;
                    }
                }
                if (izin == true)//eğer aynı isimde kart adı yoksa veritabanına bilgileri ekleme işlemine geçiyor.
                {
                    //veritabanına task bilgileri ekleniyor.
                    DateTime localTime = DateTime.Now;
                    try
                    {
                        baglanti.Open();//kartların bulunduğu tabloya kart bilgileri ekleniyor.
                        SqlCommand komut = new SqlCommand("INSERT INTO tblTasks(taskName, description, note, createDate, preDay, completeDate) VALUES " +
                            "(@taskName,@description,@note,@createDate,@preDay,@completeDate) ", baglanti);
                        komut.Parameters.Add("@taskName", SqlDbType.NVarChar).Value = (txtBoxTaskAdi.Text);
                        komut.Parameters.Add("@description", SqlDbType.NVarChar).Value = (txtBoxIsAciklamasi.Text);
                        komut.Parameters.Add("@note", SqlDbType.NVarChar).Value = (txtBoxNot.Text);
                        komut.Parameters.Add("@createDate", SqlDbType.DateTime).Value = (localTime.ToString("dd/MM/yyyy HH:mm"));
                        komut.Parameters.Add("@preDay", SqlDbType.Int).Value = Convert.ToInt32(lblTahminiSure.Text);
                        komut.Parameters.Add("@completeDate", SqlDbType.Date).Value = dtPickerSonTeslimTarihi.Value;
                        komut.ExecuteNonQuery();

                        //taskların konum bilgilerinin bulunduğu tabloya konum bilgileri ekleniyor.
                        komut = new SqlCommand("INSERT INTO tblTaskStates(taskID, stateID, userID, projectID, subsID, taskStateDate) VALUES " +
                            "((select taskID from tblTasks where description = @Description),0,(select userID from tblUsers " +
                            "where userName = @userName),(select projectID from tblProjects where projectName = @projectName)," +
                            "(select subsID from tblSubstances where subsName = @subsName),@taskStateDate)", baglanti);

                        komut.Parameters.Add("@Description", SqlDbType.NVarChar).Value = (txtBoxIsAciklamasi.Text);
                        komut.Parameters.Add("@userName", SqlDbType.NVarChar).Value = (cmbBoxUzmanAdi.Text);
                        komut.Parameters.Add("@projectName", SqlDbType.NVarChar).Value = (cmbBoxProjeAdi.Text);
                        komut.Parameters.Add("@subsName", SqlDbType.NVarChar).Value = (selectedRB.Text);
                        komut.Parameters.Add("@taskStateDate", SqlDbType.DateTime).Value = (localTime);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                    MessageBox.Show("Kart eklendi.");
                    formTemizle();//ekran temizleniyor.
                    listViewListele();//listView yenileniyor.
                }
                else
                {
                    MessageBox.Show("Aynı isme sahip kart ekleyemezsiniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş kutucuk bırakmayınız.");
            }
        }
        /// <summary>
        /// güncelle butonuna tıklandığında çalışacak method
        /// <summary>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (!textBoxIsEmpty() && lblKartNo.Text != "-")//boş textbox var mı ve listbox'dan kart seçilmiş mi diye kontrol ediliyor.
            {
                //böyle bir isme sahip task var mı diye kontrol ediliyor.
                bool izin = true;
                foreach (String tskName in taskNames)
                {
                    if (tskName != eskiTaskAdi && tskName == txtBoxTaskAdi.Text)
                    {
                        izin = false;
                    }
                }
                if (izin)//eğer farklı bir kart ismiyle güncelleme yapmak istiyorsa içeri giriyor.
                {
                    try
                    {
                        //güncellemek istediğimiz kartın ID'sine göre kartların bulunduğu tablo güncelleniyor.
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("UPDATE tblTasks SET taskName = @taskName, description = @description," +
                            " note = @note, createDate = @createDate, preDay = @preDay, completeDate = @completeDate " +
                            "where taskID = (select T.taskID from tblTasks T where T.taskID = @taskID)", baglanti);
                        //ekrandaki kart bilgileri sorgumuza parametreler olarak ekleniyor.
                        komut.Parameters.Add("@taskName", SqlDbType.NVarChar).Value = (txtBoxTaskAdi.Text);
                        komut.Parameters.Add("@description", SqlDbType.NVarChar).Value = (txtBoxIsAciklamasi.Text);
                        komut.Parameters.Add("@note", SqlDbType.NVarChar).Value = (txtBoxNot.Text);
                        komut.Parameters.Add("@createDate", SqlDbType.DateTime).Value = (lblTarih.Text);
                        komut.Parameters.Add("@preDay", SqlDbType.Int).Value = Convert.ToInt32(lblTahminiSure.Text);
                        komut.Parameters.Add("@completeDate", SqlDbType.Date).Value = (dtPickerSonTeslimTarihi.Value);
                        komut.Parameters.Add("@taskID", SqlDbType.Int).Value = Convert.ToInt32(lblKartNo.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }

                    try
                    {
                        //taskStates tablomuza güncellediğimiz kartın, seçtiğimiz iş içeriği ismine göre subsID'si güncelleniyor.
                        baglanti.Open();
                        SqlCommand komut = new SqlCommand("UPDATE tblTaskStates SET subsID = (select subsID from tblSubstances where subsName = @subsName) where taskID = @taskID", baglanti);
                        komut.Parameters.Add("@subsName", SqlDbType.NVarChar).Value = selectedRB.Text;
                        komut.Parameters.Add("@taskID", SqlDbType.Int).Value = Convert.ToInt32(lblKartNo.Text);
                        komut.ExecuteNonQuery();
                        baglanti.Close();
                        listViewListele();
                        MessageBox.Show("Kart güncellendi.");
                    }
                    catch (System.Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                        throw;
                    }
                }
                else
                {
                    MessageBox.Show("Aynı isme sahip kart ekleyemezsiniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen boş kutucuk bırakmayınız.");
            }

        }
        /// <summary>
        /// boş textBox var mı kontrolü yapan method.
        /// <summary>
        private bool textBoxIsEmpty()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox tbox = (TextBox)item;
                    if (tbox.Text == "")//eğer boş bırakılmış bir textbox var ise boş değer var anlamında true değerini döndürüyor.
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// ismine göre task bilgilerini ekrana yazdıran method.
        /// <summary>
        public void ismeGoreVeriGetir(string taskName)
        {
            try
            {
                //listView'de seçtiğimiz veya Scrum ekranında listbox'lardan seçtiğimiz kartın adına göre kartın bilgilerini ekrana dolduruyor.
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select T.*, U.userName, P.projectName, ST.subsName, ST.subsDayValue " +
                    "from tblTasks T, tblTaskStates TS, tblUsers U, tblProjects P, tblSubstances ST " +
                    "where TS.taskID = T.taskID and TS.projectID = P.projectID and TS.userID = U.userID and TS.subsID = ST.subsID and T.taskName = @taskName", baglanti);
                komut.Parameters.Add("@taskName", SqlDbType.NVarChar).Value = taskName;
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    //ekrana veritabanından okunan değerleri yazdırıyor.
                    txtBoxTaskAdi.Text = read["taskName"].ToString();
                    eskiTaskAdi = txtBoxTaskAdi.Text;
                    cmbBoxProjeAdi.Text = read["projectName"].ToString();
                    cmbBoxUzmanAdi.Text = read["userName"].ToString();
                    lblTahminiSure.Text = read["preDay"].ToString();
                    dtPickerSonTeslimTarihi.Value = Convert.ToDateTime(read["completeDate"].ToString());
                    lblKartNo.Text = read["taskID"].ToString();
                    DateTime createDT = Convert.ToDateTime(read["createDate"]);
                    lblTarih.Text = createDT.ToString("dd/MM/yyyy HH:mm");
                    txtBoxIsAciklamasi.Text = read["description"].ToString();
                    txtBoxNot.Text = read["note"].ToString();
                    //iş içeriği ismine göre radioButtonları düzenliyor.
                    if (read["subsName"].ToString() == "Yazılım") { rdoBtnYazilim.Checked = true; }
                    else if (read["subsName"].ToString() == "Tasarım") { rdoBtnTasarim.Checked = true; }
                    else { rdoBtnDonanim.Checked = true; }
                }
                baglanti.Close();
            }
            catch (System.Exception e)
            {
                MessageBox.Show("Hata: " + e);
                throw;
            }
        }
        /// <summary>
        /// listView'de item değişikliği olduğu an çalışan method.
        /// <summary>
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count < 1)//eğer herhangi bir item seçilmeyip boşluğa tıklandıysa ekranı sıfırlıyor.
            {
                formTemizle();
                return;
            }
            else//listview'den seçtiğimiz itemin ismine göre ekrana bilgileri dolduruluyor.
            {
                ismeGoreVeriGetir(listView1.SelectedItems[0].SubItems[3].Text);
            }
        }
        /// <summary>
        /// ekrandaki verileri sıfırlayan method.
        /// <summary>
        private void formTemizle()
        {
            //belirlenen default değerler atılıyor.
            DateTime localTime = DateTime.Now;
            lblTarih.Text = localTime.ToString("dd/MM/yyyy HH:mm");
            lblTahminiSure.Text = "10";
            rdoBtnYazilim.Checked = true;
            selectedRB = rdoBtnYazilim;
            lblKartNo.Text = "-";
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)//textbox olan itemleri bulup text değerlerine boşluk atıyoruz.
                {
                    TextBox txtBox = (TextBox)item;
                    txtBox.Text = "";
                }
            }
        }
        /// <summary>
        /// geri ok tuşuna basıldığı an çalışan method.(scrum formuna geçiş)
        /// <summary>
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Hide();
            Scrum scrm = new Scrum();
            scrm.Closed += (s, args) => this.Close();
            scrm.Show();
        }
        /// <summary>
        /// iş açıklamasındaki metin uzunluğuna göre tahmini süreye ekleme yapan method.
        /// <summary>
        private void txtBoxIsAciklamasi_TextChanged(object sender, EventArgs e)
        {
            int aciklamaTahminiSuresi;
            aciklamaTahminiSuresi = (Convert.ToInt32(txtBoxIsAciklamasi.TextLength) / 40) + 1;//açıklama uzunluğuna göre tahmini açıklama süresi oluşturuyor.
            lblTahminiSure.Text = (Convert.ToInt32(selectedRB.Tag) + aciklamaTahminiSuresi).ToString();//oluşturulan tahmini açıklama süresi iş içeriğinin süresine eklenip tahmini süre label'ına yazdırılıyor.
        }
        /// <summary>
        /// iş içeriğinde yaptığımız değişikliğe göre tahmini süreyi güncelleyen method.
        /// <summary>
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdoBtn = sender as RadioButton;
            if (rdoBtn.Checked)
            {
                selectedRB = rdoBtn;
                lblTahminiSure.Text = (Convert.ToInt32(lblTahminiSure.Text) + Convert.ToInt32(selectedRB.Tag)).ToString();//seçilen radioButton'un değeri tahmini süreye ekleniyor.
            }
            else
            {
                lblTahminiSure.Text = (Convert.ToInt32(lblTahminiSure.Text) - Convert.ToInt32(selectedRB.Tag)).ToString();//seçimi kaldırılan radioButton'un değeri tahmini süreden çıkarılıyor.
            }
        }
    }
}
