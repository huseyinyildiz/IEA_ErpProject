namespace IEA_ErpProject.BilgiGiris.Urunler
{
    partial class UrunKayitListesi
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.TxtUrunAra = new System.Windows.Forms.TextBox();
            this.btnUrunAra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Firma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcikTr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlUst.Controls.Add(this.TxtUrunAra);
            this.pnlUst.Controls.Add(this.btnUrunAra);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1532, 105);
            this.pnlUst.TabIndex = 0;
            // 
            // TxtUrunAra
            // 
            this.TxtUrunAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUrunAra.Location = new System.Drawing.Point(1195, 38);
            this.TxtUrunAra.Name = "TxtUrunAra";
            this.TxtUrunAra.Size = new System.Drawing.Size(304, 26);
            this.TxtUrunAra.TabIndex = 1;
            this.TxtUrunAra.TextChanged += new System.EventHandler(this.TxtUrunAra_TextChanged);
            // 
            // btnUrunAra
            // 
            this.btnUrunAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUrunAra.Location = new System.Drawing.Point(1053, 33);
            this.btnUrunAra.Name = "btnUrunAra";
            this.btnUrunAra.Size = new System.Drawing.Size(136, 36);
            this.btnUrunAra.TabIndex = 1;
            this.btnUrunAra.Text = "Ürün Ara";
            this.btnUrunAra.UseVisualStyleBackColor = true;
            this.btnUrunAra.Click += new System.EventHandler(this.btnUrunAra_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Urun Kayit Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Sira,
            this.Id,
            this.Firma,
            this.UrunKodu,
            this.AcikTr,
            this.Uid});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 105);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(1532, 537);
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
            // Firma
            // 
            this.Firma.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Firma.HeaderText = "Firma";
            this.Firma.MinimumWidth = 8;
            this.Firma.Name = "Firma";
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.MinimumWidth = 8;
            this.UrunKodu.Name = "UrunKodu";
            // 
            // AcikTr
            // 
            this.AcikTr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.AcikTr.HeaderText = "Aciklama";
            this.AcikTr.MinimumWidth = 8;
            this.AcikTr.Name = "AcikTr";
            // 
            // Uid
            // 
            this.Uid.HeaderText = "Uid";
            this.Uid.MinimumWidth = 8;
            this.Uid.Name = "Uid";
            this.Uid.Visible = false;
            this.Uid.Width = 150;
            // 
            // UrunKayitListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 642);
            this.Controls.Add(this.Liste);
            this.Controls.Add(this.pnlUst);
            this.Name = "UrunKayitListesi";
            this.Text = "UrunKayitListesi";
            this.Load += new System.EventHandler(this.UrunKayitListesi_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.TextBox TxtUrunAra;
        private System.Windows.Forms.Button btnUrunAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Firma;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcikTr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uid;
    }
}