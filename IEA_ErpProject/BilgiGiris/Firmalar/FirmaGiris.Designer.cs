namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    partial class FirmaGiris
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
            this.BtnDetayGoster = new System.Windows.Forms.Button();
            this.BtnDetayEkle = new System.Windows.Forms.Button();
            this.TxtFirmaBul = new System.Windows.Forms.TextBox();
            this.TxtFVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.TxtFAdres = new System.Windows.Forms.RichTextBox();
            this.TxtSehir = new System.Windows.Forms.ComboBox();
            this.txtFVergiDairesi = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.TxtFadi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaTip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ScFirma = new System.Windows.Forms.SplitContainer();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtFirmaTip = new System.Windows.Forms.ComboBox();
            this.TxtWeb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScFirma)).BeginInit();
            this.ScFirma.Panel1.SuspendLayout();
            this.ScFirma.Panel2.SuspendLayout();
            this.ScFirma.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnDetayGoster
            // 
            this.BtnDetayGoster.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDetayGoster.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDetayGoster.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDetayGoster.Location = new System.Drawing.Point(897, 360);
            this.BtnDetayGoster.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDetayGoster.Name = "BtnDetayGoster";
            this.BtnDetayGoster.Size = new System.Drawing.Size(194, 60);
            this.BtnDetayGoster.TabIndex = 17;
            this.BtnDetayGoster.Text = "Detay Goster";
            this.BtnDetayGoster.UseVisualStyleBackColor = false;
            this.BtnDetayGoster.Visible = false;
            this.BtnDetayGoster.Click += new System.EventHandler(this.BtnDetayGoster_Click);
            // 
            // BtnDetayEkle
            // 
            this.BtnDetayEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDetayEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnDetayEkle.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnDetayEkle.Location = new System.Drawing.Point(1113, 360);
            this.BtnDetayEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnDetayEkle.Name = "BtnDetayEkle";
            this.BtnDetayEkle.Size = new System.Drawing.Size(194, 60);
            this.BtnDetayEkle.TabIndex = 17;
            this.BtnDetayEkle.Text = "Detay Ekle";
            this.BtnDetayEkle.UseVisualStyleBackColor = false;
            this.BtnDetayEkle.Visible = false;
            this.BtnDetayEkle.Click += new System.EventHandler(this.BtnDetayEkle_Click);
            // 
            // TxtFirmaBul
            // 
            this.TxtFirmaBul.Location = new System.Drawing.Point(881, 93);
            this.TxtFirmaBul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtFirmaBul.Name = "TxtFirmaBul";
            this.TxtFirmaBul.Size = new System.Drawing.Size(244, 26);
            this.TxtFirmaBul.TabIndex = 16;
            // 
            // TxtFVergiNo
            // 
            this.TxtFVergiNo.Location = new System.Drawing.Point(631, 166);
            this.TxtFVergiNo.Mask = "00000000000";
            this.TxtFVergiNo.Name = "TxtFVergiNo";
            this.TxtFVergiNo.Size = new System.Drawing.Size(106, 26);
            this.TxtFVergiNo.TabIndex = 15;
            // 
            // TxtFAdres
            // 
            this.TxtFAdres.Location = new System.Drawing.Point(153, 278);
            this.TxtFAdres.Name = "TxtFAdres";
            this.TxtFAdres.Size = new System.Drawing.Size(259, 96);
            this.TxtFAdres.TabIndex = 13;
            this.TxtFAdres.Text = "";
            // 
            // TxtSehir
            // 
            this.TxtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSehir.FormattingEnabled = true;
            this.TxtSehir.Location = new System.Drawing.Point(163, 220);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(162, 28);
            this.TxtSehir.TabIndex = 12;
            // 
            // txtFVergiDairesi
            // 
            this.txtFVergiDairesi.Location = new System.Drawing.Point(631, 89);
            this.txtFVergiDairesi.Name = "txtFVergiDairesi";
            this.txtFVergiDairesi.Size = new System.Drawing.Size(154, 26);
            this.txtFVergiDairesi.TabIndex = 10;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(16, 25);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(50, 49);
            this.btnKaydet.TabIndex = 14;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(72, 25);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(50, 49);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // TxtFadi
            // 
            this.TxtFadi.Location = new System.Drawing.Point(140, 86);
            this.TxtFadi.Name = "TxtFadi";
            this.TxtFadi.Size = new System.Drawing.Size(286, 26);
            this.TxtFadi.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(474, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 40);
            this.label8.TabIndex = 6;
            this.label8.Text = "Vergi No";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(128, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(50, 49);
            this.btnSil.TabIndex = 12;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit_64;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(1351, 12);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(50, 49);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(12, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 40);
            this.label6.TabIndex = 4;
            this.label6.Text = "Şehir";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.FirmaTip,
            this.Sehir});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(1429, 133);
            this.Liste.TabIndex = 0;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 8;
            this.Sira.Name = "Sira";
            this.Sira.Width = 73;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Width = 59;
            // 
            // Adi
            // 
            this.Adi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Adi.HeaderText = "Firma Adı";
            this.Adi.MinimumWidth = 8;
            this.Adi.Name = "Adi";
            // 
            // FirmaTip
            // 
            this.FirmaTip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FirmaTip.HeaderText = "Firma Tipi";
            this.FirmaTip.MinimumWidth = 8;
            this.FirmaTip.Name = "FirmaTip";
            this.FirmaTip.Width = 113;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.MinimumWidth = 8;
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 82;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(474, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 40);
            this.label4.TabIndex = 2;
            this.label4.Text = "Vergi Dairesi";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Location = new System.Drawing.Point(12, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 40);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adres";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(12, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Firma Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.png_transparent_dustpan_computer_icons_iconfinder_clear_miscellaneous_angle_photography;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(184, 25);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(50, 49);
            this.btnTemizle.TabIndex = 11;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ScFirma
            // 
            this.ScFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScFirma.Location = new System.Drawing.Point(0, 92);
            this.ScFirma.Name = "ScFirma";
            this.ScFirma.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScFirma.Panel1
            // 
            this.ScFirma.Panel1.Controls.Add(this.TxtEmail);
            this.ScFirma.Panel1.Controls.Add(this.label15);
            this.ScFirma.Panel1.Controls.Add(this.txtTelefon);
            this.ScFirma.Panel1.Controls.Add(this.label5);
            this.ScFirma.Panel1.Controls.Add(this.BtnDetayGoster);
            this.ScFirma.Panel1.Controls.Add(this.BtnDetayEkle);
            this.ScFirma.Panel1.Controls.Add(this.TxtFirmaBul);
            this.ScFirma.Panel1.Controls.Add(this.TxtFVergiNo);
            this.ScFirma.Panel1.Controls.Add(this.TxtFAdres);
            this.ScFirma.Panel1.Controls.Add(this.TxtFirmaTip);
            this.ScFirma.Panel1.Controls.Add(this.TxtSehir);
            this.ScFirma.Panel1.Controls.Add(this.TxtWeb);
            this.ScFirma.Panel1.Controls.Add(this.txtFVergiDairesi);
            this.ScFirma.Panel1.Controls.Add(this.TxtFadi);
            this.ScFirma.Panel1.Controls.Add(this.label8);
            this.ScFirma.Panel1.Controls.Add(this.label7);
            this.ScFirma.Panel1.Controls.Add(this.label6);
            this.ScFirma.Panel1.Controls.Add(this.label9);
            this.ScFirma.Panel1.Controls.Add(this.label4);
            this.ScFirma.Panel1.Controls.Add(this.label3);
            this.ScFirma.Panel1.Controls.Add(this.label2);
            // 
            // ScFirma.Panel2
            // 
            this.ScFirma.Panel2.Controls.Add(this.Liste);
            this.ScFirma.Size = new System.Drawing.Size(1429, 569);
            this.ScFirma.SplitterDistance = 431;
            this.ScFirma.SplitterWidth = 5;
            this.ScFirma.TabIndex = 9;
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(602, 295);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(286, 26);
            this.TxtEmail.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label15.Location = new System.Drawing.Point(474, 289);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(100, 40);
            this.label15.TabIndex = 20;
            this.label15.Text = "Email";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(615, 227);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(127, 26);
            this.txtTelefon.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(474, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 18;
            this.label5.Text = "Telefon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtFirmaTip
            // 
            this.TxtFirmaTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtFirmaTip.FormattingEnabled = true;
            this.TxtFirmaTip.Location = new System.Drawing.Point(163, 148);
            this.TxtFirmaTip.Name = "TxtFirmaTip";
            this.TxtFirmaTip.Size = new System.Drawing.Size(225, 28);
            this.TxtFirmaTip.TabIndex = 12;
            // 
            // TxtWeb
            // 
            this.TxtWeb.Location = new System.Drawing.Point(631, 363);
            this.TxtWeb.Name = "TxtWeb";
            this.TxtWeb.Size = new System.Drawing.Size(154, 26);
            this.TxtWeb.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 40);
            this.label7.TabIndex = 4;
            this.label7.Text = "Firma Tipi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(474, 360);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 40);
            this.label9.TabIndex = 2;
            this.label9.Text = "Web";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1429, 92);
            this.label1.TabIndex = 8;
            this.label1.Text = "Firma Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirmaGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 661);
            this.Controls.Add(this.ScFirma);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.label1);
            this.Name = "FirmaGiris";
            this.Text = "FirmaGiris";
            this.Load += new System.EventHandler(this.FirmaGiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ScFirma.Panel1.ResumeLayout(false);
            this.ScFirma.Panel1.PerformLayout();
            this.ScFirma.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScFirma)).EndInit();
            this.ScFirma.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnDetayGoster;
        private System.Windows.Forms.Button BtnDetayEkle;
        private System.Windows.Forms.TextBox TxtFirmaBul;
        private System.Windows.Forms.MaskedTextBox TxtFVergiNo;
        private System.Windows.Forms.RichTextBox TxtFAdres;
        private System.Windows.Forms.ComboBox TxtSehir;
        private System.Windows.Forms.TextBox txtFVergiDairesi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox TxtFadi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.SplitContainer ScFirma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TxtFirmaTip;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaTip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtWeb;
        private System.Windows.Forms.Label label9;
    }
}