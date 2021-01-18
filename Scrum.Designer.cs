
namespace YazilimSinamaFinalProje
{
    partial class Scrum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Scrum));
            this.labelRevison = new System.Windows.Forms.Label();
            this.labelCheck = new System.Windows.Forms.Label();
            this.labelDone = new System.Windows.Forms.Label();
            this.lstBoxCheck = new System.Windows.Forms.ListBox();
            this.lstBoxDone = new System.Windows.Forms.ListBox();
            this.lstBoxRevision = new System.Windows.Forms.ListBox();
            this.labelInProgress = new System.Windows.Forms.Label();
            this.todoLabel = new System.Windows.Forms.Label();
            this.lstBoxInProgress = new System.Windows.Forms.ListBox();
            this.lstBoxToDo = new System.Windows.Forms.ListBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new ePOSOne.btnProduct.Button_WOC();
            this.btnGuncelle = new ePOSOne.btnProduct.Button_WOC();
            this.btnEkle = new ePOSOne.btnProduct.Button_WOC();
            this.SuspendLayout();
            // 
            // labelRevison
            // 
            this.labelRevison.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRevison.AutoSize = true;
            this.labelRevison.BackColor = System.Drawing.Color.Transparent;
            this.labelRevison.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRevison.Location = new System.Drawing.Point(577, 109);
            this.labelRevison.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRevison.Name = "labelRevison";
            this.labelRevison.Size = new System.Drawing.Size(77, 19);
            this.labelRevison.TabIndex = 25;
            this.labelRevison.Text = "Revision";
            // 
            // labelCheck
            // 
            this.labelCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCheck.AutoSize = true;
            this.labelCheck.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCheck.Location = new System.Drawing.Point(713, 109);
            this.labelCheck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCheck.Name = "labelCheck";
            this.labelCheck.Size = new System.Drawing.Size(64, 19);
            this.labelCheck.TabIndex = 24;
            this.labelCheck.Text = "Check";
            // 
            // labelDone
            // 
            this.labelDone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDone.AutoSize = true;
            this.labelDone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDone.Location = new System.Drawing.Point(1117, 109);
            this.labelDone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDone.Name = "labelDone";
            this.labelDone.Size = new System.Drawing.Size(53, 19);
            this.labelDone.TabIndex = 23;
            this.labelDone.Text = "Done";
            // 
            // lstBoxCheck
            // 
            this.lstBoxCheck.AllowDrop = true;
            this.lstBoxCheck.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxCheck.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxCheck.FormattingEnabled = true;
            this.lstBoxCheck.IntegralHeight = false;
            this.lstBoxCheck.ItemHeight = 27;
            this.lstBoxCheck.Location = new System.Drawing.Point(717, 132);
            this.lstBoxCheck.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxCheck.Name = "lstBoxCheck";
            this.lstBoxCheck.Size = new System.Drawing.Size(349, 459);
            this.lstBoxCheck.TabIndex = 22;
            this.lstBoxCheck.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstBoxCheck.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstBoxCheck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstBoxDone
            // 
            this.lstBoxDone.AllowDrop = true;
            this.lstBoxDone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstBoxDone.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxDone.FormattingEnabled = true;
            this.lstBoxDone.IntegralHeight = false;
            this.lstBoxDone.ItemHeight = 27;
            this.lstBoxDone.Location = new System.Drawing.Point(1121, 132);
            this.lstBoxDone.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxDone.Name = "lstBoxDone";
            this.lstBoxDone.Size = new System.Drawing.Size(349, 459);
            this.lstBoxDone.TabIndex = 21;
            this.lstBoxDone.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstBoxDone.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstBoxDone.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstBoxRevision
            // 
            this.lstBoxRevision.AllowDrop = true;
            this.lstBoxRevision.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lstBoxRevision.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxRevision.FormattingEnabled = true;
            this.lstBoxRevision.IntegralHeight = false;
            this.lstBoxRevision.ItemHeight = 27;
            this.lstBoxRevision.Location = new System.Drawing.Point(581, 132);
            this.lstBoxRevision.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxRevision.Name = "lstBoxRevision";
            this.lstBoxRevision.Size = new System.Drawing.Size(349, 459);
            this.lstBoxRevision.TabIndex = 20;
            this.lstBoxRevision.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstBoxRevision.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstBoxRevision.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // labelInProgress
            // 
            this.labelInProgress.AutoSize = true;
            this.labelInProgress.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInProgress.Location = new System.Drawing.Point(439, 109);
            this.labelInProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInProgress.Name = "labelInProgress";
            this.labelInProgress.Size = new System.Drawing.Size(98, 19);
            this.labelInProgress.TabIndex = 19;
            this.labelInProgress.Text = "In Progress";
            // 
            // todoLabel
            // 
            this.todoLabel.AutoSize = true;
            this.todoLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoLabel.Location = new System.Drawing.Point(30, 109);
            this.todoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.todoLabel.Name = "todoLabel";
            this.todoLabel.Size = new System.Drawing.Size(50, 19);
            this.todoLabel.TabIndex = 18;
            this.todoLabel.Text = "ToDo";
            // 
            // lstBoxInProgress
            // 
            this.lstBoxInProgress.AllowDrop = true;
            this.lstBoxInProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstBoxInProgress.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxInProgress.FormattingEnabled = true;
            this.lstBoxInProgress.IntegralHeight = false;
            this.lstBoxInProgress.ItemHeight = 27;
            this.lstBoxInProgress.Location = new System.Drawing.Point(443, 132);
            this.lstBoxInProgress.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxInProgress.Name = "lstBoxInProgress";
            this.lstBoxInProgress.Size = new System.Drawing.Size(349, 459);
            this.lstBoxInProgress.TabIndex = 17;
            this.lstBoxInProgress.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstBoxInProgress.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstBoxInProgress.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lstBoxToDo
            // 
            this.lstBoxToDo.AllowDrop = true;
            this.lstBoxToDo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstBoxToDo.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBoxToDo.FormattingEnabled = true;
            this.lstBoxToDo.IntegralHeight = false;
            this.lstBoxToDo.ItemHeight = 27;
            this.lstBoxToDo.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.lstBoxToDo.Location = new System.Drawing.Point(34, 132);
            this.lstBoxToDo.Margin = new System.Windows.Forms.Padding(4);
            this.lstBoxToDo.Name = "lstBoxToDo";
            this.lstBoxToDo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lstBoxToDo.Size = new System.Drawing.Size(349, 459);
            this.lstBoxToDo.TabIndex = 16;
            this.lstBoxToDo.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox_DragDrop);
            this.lstBoxToDo.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox_DragOver);
            this.lstBoxToDo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_MouseDown);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAciklama.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAciklama.Location = new System.Drawing.Point(30, 628);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(1048, 119);
            this.lblAciklama.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 605);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Açıklama:";
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.BackColor = System.Drawing.Color.Transparent;
            this.btnSil.BorderColor = System.Drawing.Color.Red;
            this.btnSil.ButtonColor = System.Drawing.Color.White;
            this.btnSil.FlatAppearance.BorderSize = 0;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSil.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Location = new System.Drawing.Point(1280, 639);
            this.btnSil.Name = "btnSil";
            this.btnSil.OnHoverBorderColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverButtonColor = System.Drawing.Color.Red;
            this.btnSil.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSil.Size = new System.Drawing.Size(190, 67);
            this.btnSil.TabIndex = 30;
            this.btnSil.Text = "Kartı Sil";
            this.btnSil.TextColor = System.Drawing.Color.Red;
            this.btnSil.UseVisualStyleBackColor = false;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnGuncelle.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.ButtonColor = System.Drawing.Color.White;
            this.btnGuncelle.FlatAppearance.BorderSize = 0;
            this.btnGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuncelle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuncelle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.Location = new System.Drawing.Point(1084, 639);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.OnHoverBorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverButtonColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnGuncelle.Size = new System.Drawing.Size(190, 67);
            this.btnGuncelle.TabIndex = 29;
            this.btnGuncelle.Text = "Kartı Güncelle";
            this.btnGuncelle.TextColor = System.Drawing.SystemColors.HotTrack;
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnEkle
            // 
            this.btnEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEkle.BackColor = System.Drawing.Color.Transparent;
            this.btnEkle.BorderColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.ButtonColor = System.Drawing.Color.White;
            this.btnEkle.FlatAppearance.BorderSize = 0;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEkle.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.Location = new System.Drawing.Point(888, 639);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.OnHoverBorderColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.OnHoverButtonColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEkle.Size = new System.Drawing.Size(190, 67);
            this.btnEkle.TabIndex = 27;
            this.btnEkle.Text = "Kart Ekle";
            this.btnEkle.TextColor = System.Drawing.Color.ForestGreen;
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Scrum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1918, 755);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.labelRevison);
            this.Controls.Add(this.labelCheck);
            this.Controls.Add(this.labelDone);
            this.Controls.Add(this.lstBoxCheck);
            this.Controls.Add(this.lstBoxDone);
            this.Controls.Add(this.lstBoxRevision);
            this.Controls.Add(this.labelInProgress);
            this.Controls.Add(this.todoLabel);
            this.Controls.Add(this.lstBoxInProgress);
            this.Controls.Add(this.lstBoxToDo);
            this.Controls.Add(this.lblAciklama);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1918, 400);
            this.Name = "Scrum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scrum";
            this.Load += new System.EventHandler(this.Scrum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRevison;
        private System.Windows.Forms.Label labelCheck;
        private System.Windows.Forms.Label labelDone;
        private System.Windows.Forms.ListBox lstBoxCheck;
        private System.Windows.Forms.ListBox lstBoxDone;
        private System.Windows.Forms.ListBox lstBoxRevision;
        private System.Windows.Forms.Label labelInProgress;
        private System.Windows.Forms.Label todoLabel;
        private System.Windows.Forms.ListBox lstBoxInProgress;
        private ePOSOne.btnProduct.Button_WOC btnEkle;
        private ePOSOne.btnProduct.Button_WOC btnGuncelle;
        private ePOSOne.btnProduct.Button_WOC btnSil;
        private System.Windows.Forms.ListBox lstBoxToDo;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label label1;
    }
}