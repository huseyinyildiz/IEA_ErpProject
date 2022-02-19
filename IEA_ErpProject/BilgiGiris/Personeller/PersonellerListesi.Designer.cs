namespace IEA_ErpProject.BilgiGiris.Personeller
{
    partial class PersonellerListesi
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnPersonelAra = new System.Windows.Forms.Button();
            this.TxtPersonelAra = new System.Windows.Forms.TextBox();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unvan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gsm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sehir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBaslangıcTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsBitisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.label1.Size = new System.Drawing.Size(936, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personeller Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.BtnPersonelAra);
            this.splitContainer1.Panel1.Controls.Add(this.TxtPersonelAra);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Liste);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1223, 652);
            this.splitContainer1.SplitterDistance = 277;
            this.splitContainer1.SplitterWidth = 6;
            this.splitContainer1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(15, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 52);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personel Adı";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnPersonelAra
            // 
            this.BtnPersonelAra.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnPersonelAra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnPersonelAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnPersonelAra.Image = global::IEA_ErpProject.Properties.Resources.Ara32x32;
            this.BtnPersonelAra.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtnPersonelAra.Location = new System.Drawing.Point(0, 562);
            this.BtnPersonelAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPersonelAra.Name = "BtnPersonelAra";
            this.BtnPersonelAra.Size = new System.Drawing.Size(273, 86);
            this.BtnPersonelAra.TabIndex = 1;
            this.BtnPersonelAra.Text = "Personel Ara";
            this.BtnPersonelAra.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnPersonelAra.UseVisualStyleBackColor = false;
            this.BtnPersonelAra.Click += new System.EventHandler(this.BtnPersonelAra_Click);
            // 
            // TxtPersonelAra
            // 
            this.TxtPersonelAra.Location = new System.Drawing.Point(15, 105);
            this.TxtPersonelAra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TxtPersonelAra.Name = "TxtPersonelAra";
            this.TxtPersonelAra.Size = new System.Drawing.Size(386, 26);
            this.TxtPersonelAra.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Adi,
            this.Unvan,
            this.Tel,
            this.Gsm,
            this.Email,
            this.Sehir,
            this.IsBaslangıcTarih,
            this.IsBitisTarih});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 80);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(936, 568);
            this.Liste.TabIndex = 1;
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
            this.Adi.HeaderText = "Personel Adı";
            this.Adi.MinimumWidth = 8;
            this.Adi.Name = "Adi";
            // 
            // Unvan
            // 
            this.Unvan.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Unvan.HeaderText = "Ünvan";
            this.Unvan.MinimumWidth = 8;
            this.Unvan.Name = "Unvan";
            this.Unvan.Width = 91;
            // 
            // Tel
            // 
            this.Tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Tel.HeaderText = "Telefon";
            this.Tel.MinimumWidth = 8;
            this.Tel.Name = "Tel";
            this.Tel.Width = 98;
            // 
            // Gsm
            // 
            this.Gsm.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Gsm.HeaderText = "Gsm";
            this.Gsm.MinimumWidth = 8;
            this.Gsm.Name = "Gsm";
            this.Gsm.Width = 79;
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 8;
            this.Email.Name = "Email";
            this.Email.Width = 84;
            // 
            // Sehir
            // 
            this.Sehir.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sehir.HeaderText = "Şehir";
            this.Sehir.MinimumWidth = 8;
            this.Sehir.Name = "Sehir";
            this.Sehir.Width = 82;
            // 
            // IsBaslangıcTarih
            // 
            this.IsBaslangıcTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IsBaslangıcTarih.HeaderText = "İş Başlangıç Tarih";
            this.IsBaslangıcTarih.MinimumWidth = 8;
            this.IsBaslangıcTarih.Name = "IsBaslangıcTarih";
            this.IsBaslangıcTarih.Width = 156;
            // 
            // IsBitisTarih
            // 
            this.IsBitisTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IsBitisTarih.HeaderText = "İş Bitiş Tarihi";
            this.IsBitisTarih.MinimumWidth = 8;
            this.IsBitisTarih.Name = "IsBitisTarih";
            this.IsBitisTarih.Width = 124;
            // 
            // PersonellerListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 652);
            this.Controls.Add(this.splitContainer1);
            this.Name = "PersonellerListesi";
            this.Text = "PersonellerListesi";
            this.Load += new System.EventHandler(this.PersonellerListesi_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnPersonelAra;
        private System.Windows.Forms.TextBox TxtPersonelAra;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unvan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gsm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBaslangıcTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsBitisTarih;
    }
}