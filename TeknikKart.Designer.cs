
namespace YazilimSinamaFinalProje
{
    partial class TeknikKart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeknikKart));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxIsAciklamasi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBoxNot = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtPickerSonTeslimTarihi = new System.Windows.Forms.DateTimePicker();
            this.chTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chDurum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAciklama = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.chID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTahminiSure = new System.Windows.Forms.Label();
            this.lblKartNo = new System.Windows.Forms.Label();
            this.txtBoxTaskAdi = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbBoxUzmanAdi = new System.Windows.Forms.ComboBox();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scrumTaskBoardProjectDataSet = new YazilimSinamaFinalProje.ScrumTaskBoardProjectDataSet();
            this.lblTarih = new System.Windows.Forms.Label();
            this.cmbBoxProjeAdi = new System.Windows.Forms.ComboBox();
            this.tblProjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnEkle = new ePOSOne.btnProduct.Button_WOC();
            this.tblProjectsTableAdapter = new YazilimSinamaFinalProje.ScrumTaskBoardProjectDataSetTableAdapters.tblProjectsTableAdapter();
            this.tblUsersTableAdapter = new YazilimSinamaFinalProje.ScrumTaskBoardProjectDataSetTableAdapters.tblUsersTableAdapter();
            this.btnGuncelle = new ePOSOne.btnProduct.Button_WOC();
            this.btnGeri = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.rdoBtnYazilim = new System.Windows.Forms.RadioButton();
            this.rdoBtnTasarim = new System.Windows.Forms.RadioButton();
            this.rdoBtnDonanim = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrumTaskBoardProjectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(511, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "TEKNİK KART";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Proje Adı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(960, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Teknik Uzman:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(434, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tahmini Süre(Gün):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Son Teslim Tarihi:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(960, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Oluşturma Tarihi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(960, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Kart No:";
            // 
            // txtBoxIsAciklamasi
            // 
            this.txtBoxIsAciklamasi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxIsAciklamasi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIsAciklamasi.Location = new System.Drawing.Point(29, 253);
            this.txtBoxIsAciklamasi.MaxLength = 500;
            this.txtBoxIsAciklamasi.Multiline = true;
            this.txtBoxIsAciklamasi.Name = "txtBoxIsAciklamasi";
            this.txtBoxIsAciklamasi.Size = new System.Drawing.Size(1440, 187);
            this.txtBoxIsAciklamasi.TabIndex = 13;
            this.txtBoxIsAciklamasi.TextChanged += new System.EventHandler(this.txtBoxIsAciklamasi_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(26, 229);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "İşin Açıklaması:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(26, 454);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Not:";
            // 
            // txtBoxNot
            // 
            this.txtBoxNot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxNot.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNot.Location = new System.Drawing.Point(29, 478);
            this.txtBoxNot.Multiline = true;
            this.txtBoxNot.Name = "txtBoxNot";
            this.txtBoxNot.Size = new System.Drawing.Size(1440, 187);
            this.txtBoxNot.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(26, 683);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 19);
            this.label10.TabIndex = 17;
            this.label10.Text = "Kartlar";
            // 
            // dtPickerSonTeslimTarihi
            // 
            this.dtPickerSonTeslimTarihi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerSonTeslimTarihi.Location = new System.Drawing.Point(631, 176);
            this.dtPickerSonTeslimTarihi.Name = "dtPickerSonTeslimTarihi";
            this.dtPickerSonTeslimTarihi.Size = new System.Drawing.Size(290, 28);
            this.dtPickerSonTeslimTarihi.TabIndex = 20;
            // 
            // chTarih
            // 
            this.chTarih.Text = "Oluşturma Tarihi";
            this.chTarih.Width = 180;
            // 
            // chDurum
            // 
            this.chDurum.Text = "Durum";
            this.chDurum.Width = 100;
            // 
            // chAciklama
            // 
            this.chAciklama.Text = "Açıklama";
            this.chAciklama.Width = 186;
            // 
            // chNot
            // 
            this.chNot.Text = "Not";
            this.chNot.Width = 579;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.BackColor = System.Drawing.Color.White;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chID,
            this.chTarih,
            this.chDurum,
            this.chAdi,
            this.chAciklama,
            this.chNot});
            this.listView1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(30, 709);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1439, 154);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // chID
            // 
            this.chID.Text = "ID";
            // 
            // chAdi
            // 
            this.chAdi.Text = "Adı";
            this.chAdi.Width = 139;
            // 
            // lblTahminiSure
            // 
            this.lblTahminiSure.AutoSize = true;
            this.lblTahminiSure.BackColor = System.Drawing.Color.White;
            this.lblTahminiSure.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTahminiSure.Location = new System.Drawing.Point(627, 138);
            this.lblTahminiSure.Name = "lblTahminiSure";
            this.lblTahminiSure.Size = new System.Drawing.Size(28, 21);
            this.lblTahminiSure.TabIndex = 21;
            this.lblTahminiSure.Text = "10";
            // 
            // lblKartNo
            // 
            this.lblKartNo.AutoSize = true;
            this.lblKartNo.BackColor = System.Drawing.Color.White;
            this.lblKartNo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKartNo.Location = new System.Drawing.Point(1116, 127);
            this.lblKartNo.Name = "lblKartNo";
            this.lblKartNo.Size = new System.Drawing.Size(0, 21);
            this.lblKartNo.TabIndex = 60;
            // 
            // txtBoxTaskAdi
            // 
            this.txtBoxTaskAdi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTaskAdi.Location = new System.Drawing.Point(164, 178);
            this.txtBoxTaskAdi.MaxLength = 25;
            this.txtBoxTaskAdi.Name = "txtBoxTaskAdi";
            this.txtBoxTaskAdi.Size = new System.Drawing.Size(200, 28);
            this.txtBoxTaskAdi.TabIndex = 62;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 181);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 19);
            this.label11.TabIndex = 61;
            this.label11.Text = "Kart Adı:";
            // 
            // cmbBoxUzmanAdi
            // 
            this.cmbBoxUzmanAdi.DataSource = this.tblUsersBindingSource;
            this.cmbBoxUzmanAdi.DisplayMember = "userName";
            this.cmbBoxUzmanAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxUzmanAdi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxUzmanAdi.FormattingEnabled = true;
            this.cmbBoxUzmanAdi.Location = new System.Drawing.Point(1120, 179);
            this.cmbBoxUzmanAdi.Name = "cmbBoxUzmanAdi";
            this.cmbBoxUzmanAdi.Size = new System.Drawing.Size(169, 29);
            this.cmbBoxUzmanAdi.TabIndex = 63;
            this.cmbBoxUzmanAdi.ValueMember = "userName";
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.scrumTaskBoardProjectDataSet;
            // 
            // scrumTaskBoardProjectDataSet
            // 
            this.scrumTaskBoardProjectDataSet.DataSetName = "ScrumTaskBoardProjectDataSet";
            this.scrumTaskBoardProjectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.BackColor = System.Drawing.Color.White;
            this.lblTarih.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarih.Location = new System.Drawing.Point(1116, 90);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(0, 21);
            this.lblTarih.TabIndex = 64;
            // 
            // cmbBoxProjeAdi
            // 
            this.cmbBoxProjeAdi.DataSource = this.tblProjectsBindingSource;
            this.cmbBoxProjeAdi.DisplayMember = "projectName";
            this.cmbBoxProjeAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxProjeAdi.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBoxProjeAdi.FormattingEnabled = true;
            this.cmbBoxProjeAdi.Location = new System.Drawing.Point(164, 136);
            this.cmbBoxProjeAdi.Name = "cmbBoxProjeAdi";
            this.cmbBoxProjeAdi.Size = new System.Drawing.Size(200, 29);
            this.cmbBoxProjeAdi.TabIndex = 65;
            this.cmbBoxProjeAdi.ValueMember = "projectName";
            // 
            // tblProjectsBindingSource
            // 
            this.tblProjectsBindingSource.DataMember = "tblProjects";
            this.tblProjectsBindingSource.DataSource = this.scrumTaskBoardProjectDataSet;
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnEkle.ButtonColor = System.Drawing.Color.White;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnEkle.Location = new System.Drawing.Point(1203, 670);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnEkle.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEkle.Size = new System.Drawing.Size(130, 32);
            this.btnEkle.TabIndex = 59;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // tblProjectsTableAdapter
            // 
            this.tblProjectsTableAdapter.ClearBeforeFill = true;
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.ButtonColor = System.Drawing.Color.White;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Location = new System.Drawing.Point(1339, 670);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuncelle.Size = new System.Drawing.Size(130, 32);
            this.btnGuncelle.TabIndex = 68;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackColor = System.Drawing.Color.Transparent;
            this.btnGeri.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGeri.FlatAppearance.BorderSize = 0;
            this.btnGeri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnGeri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeri.ForeColor = System.Drawing.Color.Transparent;
            this.btnGeri.ImageKey = "backArrow.png";
            this.btnGeri.ImageList = this.ımageList1;
            this.btnGeri.Location = new System.Drawing.Point(12, 81);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(52, 53);
            this.btnGeri.TabIndex = 69;
            this.btnGeri.UseVisualStyleBackColor = false;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "backArrow.png");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(1316, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 19);
            this.label12.TabIndex = 71;
            this.label12.Text = "İş İçeriği:";
            // 
            // rdoBtnYazilim
            // 
            this.rdoBtnYazilim.AutoSize = true;
            this.rdoBtnYazilim.Checked = true;
            this.rdoBtnYazilim.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnYazilim.Location = new System.Drawing.Point(1320, 124);
            this.rdoBtnYazilim.Name = "rdoBtnYazilim";
            this.rdoBtnYazilim.Size = new System.Drawing.Size(75, 24);
            this.rdoBtnYazilim.TabIndex = 72;
            this.rdoBtnYazilim.TabStop = true;
            this.rdoBtnYazilim.Tag = "10";
            this.rdoBtnYazilim.Text = "Yazılım";
            this.rdoBtnYazilim.UseVisualStyleBackColor = true;
            this.rdoBtnYazilim.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoBtnTasarim
            // 
            this.rdoBtnTasarim.AutoSize = true;
            this.rdoBtnTasarim.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnTasarim.Location = new System.Drawing.Point(1320, 154);
            this.rdoBtnTasarim.Name = "rdoBtnTasarim";
            this.rdoBtnTasarim.Size = new System.Drawing.Size(82, 24);
            this.rdoBtnTasarim.TabIndex = 73;
            this.rdoBtnTasarim.Tag = "7";
            this.rdoBtnTasarim.Text = "Tasarım";
            this.rdoBtnTasarim.UseVisualStyleBackColor = true;
            this.rdoBtnTasarim.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rdoBtnDonanim
            // 
            this.rdoBtnDonanim.AutoSize = true;
            this.rdoBtnDonanim.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnDonanim.Location = new System.Drawing.Point(1320, 184);
            this.rdoBtnDonanim.Name = "rdoBtnDonanim";
            this.rdoBtnDonanim.Size = new System.Drawing.Size(95, 24);
            this.rdoBtnDonanim.TabIndex = 74;
            this.rdoBtnDonanim.Tag = "5";
            this.rdoBtnDonanim.Text = "Donanım";
            this.rdoBtnDonanim.UseVisualStyleBackColor = true;
            this.rdoBtnDonanim.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // TeknikKart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnGeri;
            this.ClientSize = new System.Drawing.Size(1500, 900);
            this.Controls.Add(this.rdoBtnDonanim);
            this.Controls.Add(this.rdoBtnTasarim);
            this.Controls.Add(this.rdoBtnYazilim);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.cmbBoxProjeAdi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.cmbBoxUzmanAdi);
            this.Controls.Add(this.txtBoxTaskAdi);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblKartNo);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblTahminiSure);
            this.Controls.Add(this.dtPickerSonTeslimTarihi);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBoxNot);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBoxIsAciklamasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeknikKart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.TeknikKart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scrumTaskBoardProjectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProjectsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxIsAciklamasi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBoxNot;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtPickerSonTeslimTarihi;
        private System.Windows.Forms.ColumnHeader chTarih;
        private System.Windows.Forms.ColumnHeader chDurum;
        private System.Windows.Forms.ColumnHeader chAciklama;
        private System.Windows.Forms.ColumnHeader chNot;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lblTahminiSure;
        private ePOSOne.btnProduct.Button_WOC btnEkle;
        private System.Windows.Forms.Label lblKartNo;
        private System.Windows.Forms.TextBox txtBoxTaskAdi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbBoxUzmanAdi;
       // private ScrumTaskBoardProjectDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.ComboBox cmbBoxProjeAdi;
        private ScrumTaskBoardProjectDataSet scrumTaskBoardProjectDataSet;
        private System.Windows.Forms.BindingSource tblProjectsBindingSource;
        private ScrumTaskBoardProjectDataSetTableAdapters.tblProjectsTableAdapter tblProjectsTableAdapter;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private ScrumTaskBoardProjectDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private System.Windows.Forms.ColumnHeader chID;
        private ePOSOne.btnProduct.Button_WOC btnGuncelle;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdoBtnYazilim;
        private System.Windows.Forms.RadioButton rdoBtnTasarim;
        private System.Windows.Forms.RadioButton rdoBtnDonanim;
        private System.Windows.Forms.ColumnHeader chAdi;
    }
}

