namespace IEA_ErpProject.BilgiGiris.Hastaneler
{
    partial class HastaneGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.ScHastane = new System.Windows.Forms.SplitContainer();
            this.BtnDetayEkle = new System.Windows.Forms.Button();
            this.TxtHastaneBul = new System.Windows.Forms.TextBox();
            this.TxtVergiNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            this.TxtAdres = new System.Windows.Forms.RichTextBox();
            this.TxtSehir = new System.Windows.Forms.ComboBox();
            this.TxtTipAdi = new System.Windows.Forms.ComboBox();
            this.txtVergiDairesi = new System.Windows.Forms.TextBox();
            this.TxtCariHadi = new System.Windows.Forms.TextBox();
            this.TxtHadi = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.BtnDetayGoster = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ScHastane)).BeginInit();
            this.ScHastane.Panel1.SuspendLayout();
            this.ScHastane.Panel2.SuspendLayout();
            this.ScHastane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1320, 92);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hastane Giriş";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ScHastane
            // 
            this.ScHastane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScHastane.Location = new System.Drawing.Point(0, 92);
            this.ScHastane.Name = "ScHastane";
            this.ScHastane.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ScHastane.Panel1
            // 
            this.ScHastane.Panel1.Controls.Add(this.BtnDetayGoster);
            this.ScHastane.Panel1.Controls.Add(this.BtnDetayEkle);
            this.ScHastane.Panel1.Controls.Add(this.TxtHastaneBul);
            this.ScHastane.Panel1.Controls.Add(this.TxtVergiNo);
            this.ScHastane.Panel1.Controls.Add(this.txtTelefon);
            this.ScHastane.Panel1.Controls.Add(this.TxtAdres);
            this.ScHastane.Panel1.Controls.Add(this.TxtSehir);
            this.ScHastane.Panel1.Controls.Add(this.TxtTipAdi);
            this.ScHastane.Panel1.Controls.Add(this.txtVergiDairesi);
            this.ScHastane.Panel1.Controls.Add(this.TxtCariHadi);
            this.ScHastane.Panel1.Controls.Add(this.TxtHadi);
            this.ScHastane.Panel1.Controls.Add(this.label9);
            this.ScHastane.Panel1.Controls.Add(this.label8);
            this.ScHastane.Panel1.Controls.Add(this.label7);
            this.ScHastane.Panel1.Controls.Add(this.label6);
            this.ScHastane.Panel1.Controls.Add(this.label5);
            this.ScHastane.Panel1.Controls.Add(this.label4);
            this.ScHastane.Panel1.Controls.Add(this.label3);
            this.ScHastane.Panel1.Controls.Add(this.label2);
            // 
            // ScHastane.Panel2
            // 
            this.ScHastane.Panel2.Controls.Add(this.Liste);
            this.ScHastane.Size = new System.Drawing.Size(1320, 580);
            this.ScHastane.SplitterDistance = 440;
            this.ScHastane.SplitterWidth = 5;
            this.ScHastane.TabIndex = 2;
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
            // TxtHastaneBul
            // 
            this.TxtHastaneBul.Location = new System.Drawing.Point(1072, 0);
            this.TxtHastaneBul.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtHastaneBul.Name = "TxtHastaneBul";
            this.TxtHastaneBul.Size = new System.Drawing.Size(244, 26);
            this.TxtHastaneBul.TabIndex = 16;
            // 
            // TxtVergiNo
            // 
            this.TxtVergiNo.Location = new System.Drawing.Point(970, 155);
            this.TxtVergiNo.Mask = "00000000000";
            this.TxtVergiNo.Name = "TxtVergiNo";
            this.TxtVergiNo.Size = new System.Drawing.Size(106, 26);
            this.TxtVergiNo.TabIndex = 15;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(612, 155);
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(127, 26);
            this.txtTelefon.TabIndex = 14;
            // 
            // TxtAdres
            // 
            this.TxtAdres.Location = new System.Drawing.Point(153, 278);
            this.TxtAdres.Name = "TxtAdres";
            this.TxtAdres.Size = new System.Drawing.Size(259, 96);
            this.TxtAdres.TabIndex = 13;
            this.TxtAdres.Text = "";
            // 
            // TxtSehir
            // 
            this.TxtSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtSehir.FormattingEnabled = true;
            this.TxtSehir.Location = new System.Drawing.Point(612, 82);
            this.TxtSehir.Name = "TxtSehir";
            this.TxtSehir.Size = new System.Drawing.Size(162, 28);
            this.TxtSehir.TabIndex = 12;
            // 
            // TxtTipAdi
            // 
            this.TxtTipAdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TxtTipAdi.FormattingEnabled = true;
            this.TxtTipAdi.Location = new System.Drawing.Point(153, 211);
            this.TxtTipAdi.Name = "TxtTipAdi";
            this.TxtTipAdi.Size = new System.Drawing.Size(206, 28);
            this.TxtTipAdi.TabIndex = 11;
            // 
            // txtVergiDairesi
            // 
            this.txtVergiDairesi.Location = new System.Drawing.Point(970, 78);
            this.txtVergiDairesi.Name = "txtVergiDairesi";
            this.txtVergiDairesi.Size = new System.Drawing.Size(154, 26);
            this.txtVergiDairesi.TabIndex = 10;
            // 
            // TxtCariHadi
            // 
            this.TxtCariHadi.Location = new System.Drawing.Point(140, 148);
            this.TxtCariHadi.Name = "TxtCariHadi";
            this.TxtCariHadi.Size = new System.Drawing.Size(286, 26);
            this.TxtCariHadi.TabIndex = 9;
            // 
            // TxtHadi
            // 
            this.TxtHadi.Location = new System.Drawing.Point(140, 86);
            this.TxtHadi.Name = "TxtHadi";
            this.TxtHadi.Size = new System.Drawing.Size(286, 26);
            this.TxtHadi.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label9.Location = new System.Drawing.Point(12, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 40);
            this.label9.TabIndex = 7;
            this.label9.Text = "Hastane Tipi:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(813, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 40);
            this.label8.TabIndex = 6;
            this.label8.Text = "Vergi No";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label7.Location = new System.Drawing.Point(12, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 40);
            this.label7.TabIndex = 5;
            this.label7.Text = "Cari Adı";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Location = new System.Drawing.Point(471, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 40);
            this.label6.TabIndex = 4;
            this.label6.Text = "Şehir";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(471, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 40);
            this.label5.TabIndex = 3;
            this.label5.Text = "Telefon";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Location = new System.Drawing.Point(813, 75);
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
            this.label2.Text = "Hastane Adı:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.TipId,
            this.Tel,
            this.Sehir});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(1320, 135);
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
            this.Adi.HeaderText = "Hastane Adı";
            this.Adi.MinimumWidth = 8;
            this.Adi.Name = "Adi";
            // 
            // TipId
            // 
            this.TipId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TipId.HeaderText = "Hastane Tipi";
            this.TipId.MinimumWidth = 8;
            this.TipId.Name = "TipId";
            this.TipId.Width = 134;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.MinimumWidth = 8;
            this.Tel.Name = "Tel";
            this.Tel.Width = 98;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.MinimumWidth = 8;
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 82;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(16, 25);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(50, 49);
            this.btnKaydet.TabIndex = 7;
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
            this.btnGuncelle.TabIndex = 6;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(128, 25);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(50, 49);
            this.btnSil.TabIndex = 5;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.png_transparent_dustpan_computer_icons_iconfinder_clear_miscellaneous_angle_photography;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(184, 25);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(50, 49);
            this.btnTemizle.TabIndex = 4;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit_64;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(1258, 25);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(50, 49);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.UseVisualStyleBackColor = true;
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
            // HastaneGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 672);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.ScHastane);
            this.Controls.Add(this.label1);
            this.Name = "HastaneGiris";
            this.Text = "HastaneGiris";
            this.Load += new System.EventHandler(this.HastaneGiris_Load);
            this.ScHastane.Panel1.ResumeLayout(false);
            this.ScHastane.Panel1.PerformLayout();
            this.ScHastane.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ScHastane)).EndInit();
            this.ScHastane.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer ScHastane;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox TxtVergiNo;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.RichTextBox TxtAdres;
        private System.Windows.Forms.ComboBox TxtSehir;
        private System.Windows.Forms.ComboBox TxtTipAdi;
        private System.Windows.Forms.TextBox txtVergiDairesi;
        private System.Windows.Forms.TextBox TxtCariHadi;
        private System.Windows.Forms.TextBox TxtHadi;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.TextBox TxtHastaneBul;
        private System.Windows.Forms.Button BtnDetayEkle;
        private System.Windows.Forms.Button BtnDetayGoster;
    }
}