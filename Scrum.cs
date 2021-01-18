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
    public partial class Scrum : MaterialSkin.Controls.MaterialForm
    {
        public int stateId;
        public static string connectionSource = Properties.Settings.Default.ScrumTaskBoardProjectConnectionString;
        SqlConnection baglanti = new SqlConnection(connectionSource);
        MaterialSkinManager skinManager;
        public Scrum()
        {
            InitializeComponent();
            skinManager = MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue900, Primary.Blue900, Accent.LightBlue200, TextShade.BLACK);
        }
        public int selectedIndex;
        public bool selected = false;
        ListBox eskiListBox = new ListBox();
        private void Scrum_Load(object sender, EventArgs e)
        {
            //ekran boyutunu ayarlıyor.
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Left = Top = 0;
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            listBoxDoldur();

        }
        //ekranda herhangi bir değişiklik olduğunda ekrana veritabanından güncellenmiş verileri çekiyor.
        public void listBoxDoldur()
        {
            foreach (Control item in this.Controls)
            {
                if (item is ListBox)
                {
                    ListBox lstbox = (ListBox)item;
                    lstbox.Items.Clear();
                }
            }
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("select T.taskName,T.description, TS.stateID from tblTasks T, tblTaskStates TS where T.taskID = TS.taskID", baglanti);
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                     stateId = Convert.ToInt32(read["stateID"]);
                    if (stateId == 0) { lstBoxToDo.Items.Add(read["taskName"].ToString()); }
                    else if (stateId == 1) { lstBoxInProgress.Items.Add(read["taskName"].ToString()); }
                    else if (stateId == 2) { lstBoxRevision.Items.Add(read["taskName"].ToString()); }
                    else if (stateId == 3) { lstBoxCheck.Items.Add(read["taskName"].ToString()); }
                    else { lstBoxDone.Items.Add(read["taskName"].ToString()); }
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }
        }
        //Listboxtaki seçilen verinin sırasını sira değişkenine atıyor.
        private void aktarmaMouseDown(MouseEventArgs e, ListBox lstbox)
        {
            Point nokta = new Point(e.X, e.Y);
            selectedIndex = lstbox.IndexFromPoint(nokta);
            if (e.Button == MouseButtons.Left)
            {
                if (selectedIndex != -1)
                {
                    selected = true;
                    ismeGoreAciklamaGetir(lstbox.SelectedItem.ToString());
                    lstbox.DoDragDrop(lstbox.Items[selectedIndex], DragDropEffects.All);
                }
            }
        }

        //Listboxtaki seçilen verinin sürüklenmesine yariyor.
        private void aktarmaDragOver(DragEventArgs e)
        {
            if (e.KeyState == 1)
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        //sürüklenen veriyi bıraktığımız anda çalışan method(listboxlardan veri ekleme veri silme işlemi yapıyor).
        private void aktarmaDragDrop(DragEventArgs e, ListBox lstbxEski, ListBox lstbxYeni)
        {
            //itemin yeni konumunu belirliyor
            int stateId;
            if (lstbxYeni.Name == "lstBoxToDo") { stateId = 0; }
            else if (lstbxYeni.Name == "lstBoxInProgress") { stateId = 1; }
            else if (lstbxYeni.Name == "lstBoxRevision") { stateId = 2; }
            else if (lstbxYeni.Name == "lstBoxCheck") { stateId = 3; }
            else { stateId = 4; }

            //veritabanında konumu değişen verinin bilgilerini güncelliyor.
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE tblTaskStates SET stateID = @StateID, taskStateDate = GETDATE() " +
                    "where taskID = (select T.taskID from tblTasks T where T.taskName = @taskName)", baglanti);
                komut.Parameters.Add("@StateID", SqlDbType.Int).Value = (stateId);
                komut.Parameters.Add("@taskName", SqlDbType.NVarChar).Value = (e.Data.GetData(DataFormats.StringFormat).ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
            lstbxYeni.Items.Add(e.Data.GetData(DataFormats.StringFormat).ToString());
            lstbxEski.Items.RemoveAt(selectedIndex);
            selected = false;
        }

        //listbox'a bastığımız an çalışan method
        private void listBox_MouseDown(object sender, MouseEventArgs e)
        {
            eskiListBox = sender as ListBox;
            aktarmaMouseDown(e, eskiListBox);//üstüne tıkladığımız listbox'ın ve mouse'umuzun özellikleri gönderiliyor
        }
        //listbox'tan başka bir yere sürüklerken çalışan method
        private void listBox_DragOver(object sender, DragEventArgs e)
        {
            aktarmaDragOver(e);
        }
        //sürüklediğimiz itami başka bir listbox'a bıraktığımız an çalışan method
        private void listBox_DragDrop(object sender, DragEventArgs e)
        {
            if (eskiListBox != sender as ListBox)
            {
                aktarmaDragDrop(e, eskiListBox, sender as ListBox);
            }
        }

        public void ismeGoreAciklamaGetir(String taskName)
        {
            //seçilen task'ın ismine göre ekranın sol altında bulunan açıklama label'ına açıklaması yazdırılıyor
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select T.*, U.userName, P.projectName " +
                    "from tblTasks T, tblTaskStates TS, tblUsers U, tblProjects P " +
                    "where TS.taskID = T.taskID and TS.projectID = P.projectID and TS.userID = U.userID and T.taskName = @taskName", baglanti);
                komut.Parameters.Add("@taskName", SqlDbType.NVarChar).Value = taskName;
                SqlDataReader read = komut.ExecuteReader();
                while (read.Read())
                {
                    lblAciklama.Text = read["description"].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            //yeni kart eklemek için teknik kart ekranına geçiş yapılıyor
            this.Hide();
            TeknikKart tknkKrt = new TeknikKart();
            tknkKrt.Closed += (s, args) => this.Close();
            tknkKrt.Show();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (selected)//eger listboxlardan task seçildiyse işlem yapabilecek
            {
                //teknik kart ekranına geçiş yapıp task'ın adına göre bilgileri dolduruyoruz
                this.Hide();
                TeknikKart tknkKrt = new TeknikKart();
                tknkKrt.Closed += (s, args) => this.Close();
                tknkKrt.Show();
                tknkKrt.ismeGoreVeriGetir(eskiListBox.SelectedItem.ToString());
            }
            else
            {
                MessageBox.Show("Lütfen bir task seçiniz");
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {

            if (selected)//eger listboxlardan task seçildiyse işlem yapabilecek
            {
                try
                {
                    //Task silme işlemleri burada gerçekleşiyor
                    baglanti.Open();
                    SqlCommand komut = new SqlCommand("delete from tblTasks where taskName = @taskName", baglanti);
                    komut.Parameters.Add("@taskName", SqlDbType.NVarChar).Value = (eskiListBox.SelectedItem.ToString());
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    listBoxDoldur();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir task seçiniz");
            }
        }



    }
}
