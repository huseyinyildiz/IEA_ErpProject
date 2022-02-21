﻿namespace IEA_ErpProject.BilgiGiris.Firmalar
{
    partial class FirmaDetay
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
            this.BtnKaydet = new System.Windows.Forms.Button();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Departman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Yetkili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtEmail = new System.Windows.Forms.TextBox();
            this.TxtTel = new System.Windows.Forms.MaskedTextBox();
            this.TxtGsm = new System.Windows.Forms.MaskedTextBox();
            this.TxtDeparman = new System.Windows.Forms.ComboBox();
            this.TxtYetkili = new System.Windows.Forms.TextBox();
            this.LblFirmaId = new System.Windows.Forms.Label();
            this.lblFirmaAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Location = new System.Drawing.Point(973, 518);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(123, 70);
            this.BtnKaydet.TabIndex = 19;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.UseVisualStyleBackColor = true;
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // Gsm
            // 
            this.Gsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gsm.HeaderText = "Gsm";
            this.Gsm.MinimumWidth = 8;
            this.Gsm.Name = "Gsm";
            this.Gsm.Width = 79;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.MinimumWidth = 8;
            this.Tel.Name = "Tel";
            this.Tel.Width = 98;
            // 
            // Departman
            // 
            this.Departman.HeaderText = "Departman";
            this.Departman.MinimumWidth = 8;
            this.Departman.Name = "Departman";
            this.Departman.Width = 150;
            // 
            // Yetkili
            // 
            this.Yetkili.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Yetkili.HeaderText = "Yetkili";
            this.Yetkili.MinimumWidth = 8;
            this.Yetkili.Name = "Yetkili";
            // 
            // GirisAdi
            // 
            this.GirisAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisAdi.HeaderText = "GirisAdi";
            this.GirisAdi.MinimumWidth = 8;
            this.GirisAdi.Name = "GirisAdi";
            // 
            // GirisId
            // 
            this.GirisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisId.HeaderText = "GirisId";
            this.GirisId.MinimumWidth = 8;
            this.GirisId.Name = "GirisId";
            this.GirisId.Width = 91;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 8;
            this.Sira.Name = "Sira";
            this.Sira.Width = 73;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.GirisId,
            this.GirisAdi,
            this.Yetkili,
            this.Departman,
            this.Tel,
            this.Gsm,
            this.Email});
            this.Liste.Location = new System.Drawing.Point(36, 280);
            this.Liste.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 62;
            this.Liste.Size = new System.Drawing.Size(1060, 209);
            this.Liste.TabIndex = 18;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(1036, 137);
            this.BtnEkle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(112, 35);
            this.BtnEkle.TabIndex = 17;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtEmail
            // 
            this.TxtEmail.Location = new System.Drawing.Point(774, 141);
            this.TxtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Size = new System.Drawing.Size(254, 26);
            this.TxtEmail.TabIndex = 16;
            // 
            // TxtTel
            // 
            this.TxtTel.Location = new System.Drawing.Point(456, 141);
            this.TxtTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtTel.Mask = "(999) 000-0000";
            this.TxtTel.Name = "TxtTel";
            this.TxtTel.Size = new System.Drawing.Size(148, 26);
            this.TxtTel.TabIndex = 14;
            // 
            // TxtGsm
            // 
            this.TxtGsm.Location = new System.Drawing.Point(614, 141);
            this.TxtGsm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtGsm.Mask = "(999) 000-0000";
            this.TxtGsm.Name = "TxtGsm";
            this.TxtGsm.Size = new System.Drawing.Size(148, 26);
            this.TxtGsm.TabIndex = 15;
            // 
            // TxtDeparman
            // 
            this.TxtDeparman.FormattingEnabled = true;
            this.TxtDeparman.Location = new System.Drawing.Point(264, 140);
            this.TxtDeparman.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtDeparman.Name = "TxtDeparman";
            this.TxtDeparman.Size = new System.Drawing.Size(180, 28);
            this.TxtDeparman.TabIndex = 13;
            // 
            // TxtYetkili
            // 
            this.TxtYetkili.Location = new System.Drawing.Point(-2, 141);
            this.TxtYetkili.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtYetkili.Name = "TxtYetkili";
            this.TxtYetkili.Size = new System.Drawing.Size(254, 26);
            this.TxtYetkili.TabIndex = 12;
            // 
            // LblFirmaId
            // 
            this.LblFirmaId.BackColor = System.Drawing.Color.SteelBlue;
            this.LblFirmaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblFirmaId.ForeColor = System.Drawing.SystemColors.Control;
            this.LblFirmaId.Location = new System.Drawing.Point(257, 42);
            this.LblFirmaId.Name = "LblFirmaId";
            this.LblFirmaId.Size = new System.Drawing.Size(60, 52);
            this.LblFirmaId.TabIndex = 11;
            this.LblFirmaId.Text = "****";
            this.LblFirmaId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFirmaAdi
            // 
            this.lblFirmaAdi.BackColor = System.Drawing.Color.SteelBlue;
            this.lblFirmaAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFirmaAdi.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFirmaAdi.Location = new System.Drawing.Point(341, 42);
            this.lblFirmaAdi.Name = "lblFirmaAdi";
            this.lblFirmaAdi.Size = new System.Drawing.Size(512, 52);
            this.lblFirmaAdi.TabIndex = 10;
            this.lblFirmaAdi.Text = "****";
            this.lblFirmaAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirmaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 632);
            this.Controls.Add(this.BtnKaydet);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.TxtTel);
            this.Controls.Add(this.TxtGsm);
            this.Controls.Add(this.TxtDeparman);
            this.Controls.Add(this.TxtYetkili);
            this.Controls.Add(this.LblFirmaId);
            this.Controls.Add(this.lblFirmaAdi);
            this.Name = "FirmaDetay";
            this.Text = "FirmaDetay";
            this.Load += new System.EventHandler(this.FirmaDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnKaydet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Departman;
        private System.Windows.Forms.DataGridViewTextBoxColumn Yetkili;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtEmail;
        private System.Windows.Forms.MaskedTextBox TxtTel;
        private System.Windows.Forms.MaskedTextBox TxtGsm;
        private System.Windows.Forms.ComboBox TxtDeparman;
        private System.Windows.Forms.TextBox TxtYetkili;
        public System.Windows.Forms.Label LblFirmaId;
        public System.Windows.Forms.Label lblFirmaAdi;
    }
}