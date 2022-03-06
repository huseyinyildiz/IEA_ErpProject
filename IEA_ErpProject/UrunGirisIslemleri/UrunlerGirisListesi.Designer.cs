namespace IEA_ErpProject.UrunGirisIslemleri
{
    partial class UrunlerGirisListesi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.TxtGirisAra = new System.Windows.Forms.TextBox();
            this.btnGirisBul = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CariTur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cari = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcikTr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GirisId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.CariTur,
            this.Cari,
            this.FaturaNo,
            this.GirisTarih,
            this.AcikTr,
            this.GirisId});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 105);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(1594, 676);
            this.Liste.TabIndex = 3;
            this.Liste.DoubleClick += new System.EventHandler(this.Liste_DoubleClick);
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.TxtGirisAra);
            this.pnlUst.Controls.Add(this.btnGirisBul);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1594, 105);
            this.pnlUst.TabIndex = 2;
            // 
            // TxtGirisAra
            // 
            this.TxtGirisAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtGirisAra.Location = new System.Drawing.Point(1257, 38);
            this.TxtGirisAra.Name = "TxtGirisAra";
            this.TxtGirisAra.Size = new System.Drawing.Size(304, 26);
            this.TxtGirisAra.TabIndex = 1;
            // 
            // btnGirisBul
            // 
            this.btnGirisBul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGirisBul.Location = new System.Drawing.Point(1115, 33);
            this.btnGirisBul.Name = "btnGirisBul";
            this.btnGirisBul.Size = new System.Drawing.Size(136, 36);
            this.btnGirisBul.TabIndex = 1;
            this.btnGirisBul.Text = "Giriş Bul";
            this.btnGirisBul.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Giriş Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // CariTur
            // 
            this.CariTur.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CariTur.HeaderText = "Cari Tür";
            this.CariTur.MinimumWidth = 8;
            this.CariTur.Name = "CariTur";
            // 
            // Cari
            // 
            this.Cari.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Cari.HeaderText = "Cari Adi";
            this.Cari.MinimumWidth = 8;
            this.Cari.Name = "Cari";
            // 
            // FaturaNo
            // 
            this.FaturaNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.FaturaNo.HeaderText = "Fatura ";
            this.FaturaNo.MinimumWidth = 8;
            this.FaturaNo.Name = "FaturaNo";
            this.FaturaNo.Width = 96;
            // 
            // GirisTarih
            // 
            this.GirisTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisTarih.HeaderText = "GirisTarih";
            this.GirisTarih.MinimumWidth = 8;
            this.GirisTarih.Name = "GirisTarih";
            this.GirisTarih.Width = 112;
            // 
            // AcikTr
            // 
            this.AcikTr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.AcikTr.DefaultCellStyle = dataGridViewCellStyle1;
            this.AcikTr.HeaderText = "Aciklama";
            this.AcikTr.MinimumWidth = 8;
            this.AcikTr.Name = "AcikTr";
            // 
            // GirisId
            // 
            this.GirisId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GirisId.HeaderText = "GirisId";
            this.GirisId.MinimumWidth = 8;
            this.GirisId.Name = "GirisId";
            this.GirisId.Visible = false;
            this.GirisId.Width = 91;
            // 
            // UrunlerGirisListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 781);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "UrunlerGirisListesi";
            this.Text = "UrunlerListesi";
            this.Load += new System.EventHandler(this.UrunlerGirisListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox TxtGirisAra;
        private System.Windows.Forms.Button btnGirisBul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CariTur;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cari;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcikTr;
        private System.Windows.Forms.DataGridViewTextBoxColumn GirisId;
    }
}