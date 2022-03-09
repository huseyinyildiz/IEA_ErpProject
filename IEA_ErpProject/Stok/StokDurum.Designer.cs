namespace IEA_ErpProject.Stok
{
    partial class StokDurum
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
            this.splStokDurum = new System.Windows.Forms.SplitContainer();
            this.ListeStok = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.ListeSube = new System.Windows.Forms.DataGridView();
            this.splitter4 = new System.Windows.Forms.Splitter();
            this.splitter3 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.ListeKonsinye = new System.Windows.Forms.DataGridView();
            this.ListeUrunHareket = new System.Windows.Forms.DataGridView();
            this.tcStokDurum = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ListeStok1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sBarkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sLot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sStokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sRafAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sKonsinyeAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sSubeAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sUrunHareket = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SkTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StokAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RafAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splStokDurum)).BeginInit();
            this.splStokDurum.Panel1.SuspendLayout();
            this.splStokDurum.Panel2.SuspendLayout();
            this.splStokDurum.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).BeginInit();
            this.tcStokDurum.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok1)).BeginInit();
            this.SuspendLayout();
            // 
            // splStokDurum
            // 
            this.splStokDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splStokDurum.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splStokDurum.Location = new System.Drawing.Point(0, 0);
            this.splStokDurum.Name = "splStokDurum";
            this.splStokDurum.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splStokDurum.Panel1
            // 
            this.splStokDurum.Panel1.Controls.Add(this.tcStokDurum);
            this.splStokDurum.Panel1.Controls.Add(this.splitter1);
            this.splStokDurum.Panel1.Controls.Add(this.pnlSol);
            // 
            // splStokDurum.Panel2
            // 
            this.splStokDurum.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splStokDurum.Panel2.Controls.Add(this.ListeSube);
            this.splStokDurum.Panel2.Controls.Add(this.splitter4);
            this.splStokDurum.Panel2.Controls.Add(this.splitter3);
            this.splStokDurum.Panel2.Controls.Add(this.splitter2);
            this.splStokDurum.Panel2.Controls.Add(this.ListeKonsinye);
            this.splStokDurum.Panel2.Controls.Add(this.ListeUrunHareket);
            this.splStokDurum.Size = new System.Drawing.Size(1616, 710);
            this.splStokDurum.SplitterDistance = 436;
            this.splStokDurum.TabIndex = 0;
            // 
            // ListeStok
            // 
            this.ListeStok.BackgroundColor = System.Drawing.Color.Aqua;
            this.ListeStok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.sBarkod,
            this.sUrunKodu,
            this.sLot,
            this.sStokAdet,
            this.sRafAdet,
            this.sKonsinyeAdet,
            this.sSubeAdet,
            this.sUrunHareket,
            this.Uts,
            this.UTarih,
            this.SkTarih});
            this.ListeStok.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok.Location = new System.Drawing.Point(3, 3);
            this.ListeStok.Name = "ListeStok";
            this.ListeStok.RowHeadersWidth = 62;
            this.ListeStok.RowTemplate.Height = 28;
            this.ListeStok.Size = new System.Drawing.Size(1360, 397);
            this.ListeStok.TabIndex = 2;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.IndianRed;
            this.splitter1.Location = new System.Drawing.Point(239, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 436);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.Color.Red;
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 0);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(239, 436);
            this.pnlSol.TabIndex = 0;
            // 
            // ListeSube
            // 
            this.ListeSube.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.ListeSube.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeSube.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeSube.Location = new System.Drawing.Point(318, 0);
            this.ListeSube.Name = "ListeSube";
            this.ListeSube.RowHeadersWidth = 62;
            this.ListeSube.RowTemplate.Height = 28;
            this.ListeSube.Size = new System.Drawing.Size(980, 270);
            this.ListeSube.TabIndex = 5;
            // 
            // splitter4
            // 
            this.splitter4.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter4.Location = new System.Drawing.Point(1298, 0);
            this.splitter4.Name = "splitter4";
            this.splitter4.Size = new System.Drawing.Size(3, 270);
            this.splitter4.TabIndex = 4;
            this.splitter4.TabStop = false;
            // 
            // splitter3
            // 
            this.splitter3.Location = new System.Drawing.Point(315, 0);
            this.splitter3.Name = "splitter3";
            this.splitter3.Size = new System.Drawing.Size(3, 270);
            this.splitter3.TabIndex = 3;
            this.splitter3.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(312, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 270);
            this.splitter2.TabIndex = 2;
            this.splitter2.TabStop = false;
            // 
            // ListeKonsinye
            // 
            this.ListeKonsinye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeKonsinye.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListeKonsinye.Location = new System.Drawing.Point(1301, 0);
            this.ListeKonsinye.Name = "ListeKonsinye";
            this.ListeKonsinye.RowHeadersWidth = 62;
            this.ListeKonsinye.RowTemplate.Height = 28;
            this.ListeKonsinye.Size = new System.Drawing.Size(315, 270);
            this.ListeKonsinye.TabIndex = 1;
            // 
            // ListeUrunHareket
            // 
            this.ListeUrunHareket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeUrunHareket.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListeUrunHareket.Location = new System.Drawing.Point(0, 0);
            this.ListeUrunHareket.Name = "ListeUrunHareket";
            this.ListeUrunHareket.RowHeadersWidth = 62;
            this.ListeUrunHareket.RowTemplate.Height = 28;
            this.ListeUrunHareket.Size = new System.Drawing.Size(312, 270);
            this.ListeUrunHareket.TabIndex = 0;
            // 
            // tcStokDurum
            // 
            this.tcStokDurum.Controls.Add(this.tabPage1);
            this.tcStokDurum.Controls.Add(this.tabPage2);
            this.tcStokDurum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcStokDurum.Location = new System.Drawing.Point(242, 0);
            this.tcStokDurum.Name = "tcStokDurum";
            this.tcStokDurum.SelectedIndex = 0;
            this.tcStokDurum.Size = new System.Drawing.Size(1374, 436);
            this.tcStokDurum.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ListeStok);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1366, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "StokDurum-1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ListeStok1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1366, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "StokDurum-2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ListeStok1
            // 
            this.ListeStok1.BackgroundColor = System.Drawing.Color.Aquamarine;
            this.ListeStok1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListeStok1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barkod,
            this.UrunKodu,
            this.LotSeri,
            this.StokAdet,
            this.RafAdet});
            this.ListeStok1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListeStok1.Location = new System.Drawing.Point(3, 3);
            this.ListeStok1.Name = "ListeStok1";
            this.ListeStok1.RowHeadersWidth = 62;
            this.ListeStok1.RowTemplate.Height = 28;
            this.ListeStok1.Size = new System.Drawing.Size(1360, 397);
            this.ListeStok1.TabIndex = 3;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 59;
            // 
            // sBarkod
            // 
            this.sBarkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sBarkod.HeaderText = "Barkod";
            this.sBarkod.MinimumWidth = 8;
            this.sBarkod.Name = "sBarkod";
            this.sBarkod.Visible = false;
            this.sBarkod.Width = 96;
            // 
            // sUrunKodu
            // 
            this.sUrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sUrunKodu.HeaderText = "UrunKodu";
            this.sUrunKodu.MinimumWidth = 8;
            this.sUrunKodu.Name = "sUrunKodu";
            // 
            // sLot
            // 
            this.sLot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sLot.HeaderText = "Lot Seri No";
            this.sLot.MinimumWidth = 8;
            this.sLot.Name = "sLot";
            this.sLot.Width = 124;
            // 
            // sStokAdet
            // 
            this.sStokAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sStokAdet.HeaderText = "StokAdet";
            this.sStokAdet.MinimumWidth = 8;
            this.sStokAdet.Name = "sStokAdet";
            this.sStokAdet.Width = 112;
            // 
            // sRafAdet
            // 
            this.sRafAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sRafAdet.HeaderText = "RafAdet";
            this.sRafAdet.MinimumWidth = 8;
            this.sRafAdet.Name = "sRafAdet";
            this.sRafAdet.Width = 105;
            // 
            // sKonsinyeAdet
            // 
            this.sKonsinyeAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sKonsinyeAdet.HeaderText = "KonsinyeAdet";
            this.sKonsinyeAdet.MinimumWidth = 8;
            this.sKonsinyeAdet.Name = "sKonsinyeAdet";
            this.sKonsinyeAdet.Width = 143;
            // 
            // sSubeAdet
            // 
            this.sSubeAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sSubeAdet.HeaderText = "SubeAdet";
            this.sSubeAdet.MinimumWidth = 8;
            this.sSubeAdet.Name = "sSubeAdet";
            this.sSubeAdet.Width = 117;
            // 
            // sUrunHareket
            // 
            this.sUrunHareket.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.sUrunHareket.HeaderText = "Urun Hareket Adet";
            this.sUrunHareket.MinimumWidth = 8;
            this.sUrunHareket.Name = "sUrunHareket";
            this.sUrunHareket.Width = 164;
            // 
            // Uts
            // 
            this.Uts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Uts.HeaderText = "Uts";
            this.Uts.MinimumWidth = 8;
            this.Uts.Name = "Uts";
            this.Uts.Width = 40;
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UTarih.HeaderText = "Uretim Tarihi";
            this.UTarih.MinimumWidth = 8;
            this.UTarih.Name = "UTarih";
            this.UTarih.Visible = false;
            this.UTarih.Width = 124;
            // 
            // SkTarih
            // 
            this.SkTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SkTarih.HeaderText = "SonKullanma T";
            this.SkTarih.MinimumWidth = 8;
            this.SkTarih.Name = "SkTarih";
            this.SkTarih.Visible = false;
            this.SkTarih.Width = 140;
            // 
            // Barkod
            // 
            this.Barkod.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Barkod.HeaderText = "Barkod";
            this.Barkod.MinimumWidth = 8;
            this.Barkod.Name = "Barkod";
            this.Barkod.Width = 96;
            // 
            // UrunKodu
            // 
            this.UrunKodu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UrunKodu.HeaderText = "Urun Kodu";
            this.UrunKodu.MinimumWidth = 8;
            this.UrunKodu.Name = "UrunKodu";
            // 
            // LotSeri
            // 
            this.LotSeri.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.LotSeri.HeaderText = "Lot Seri No";
            this.LotSeri.MinimumWidth = 8;
            this.LotSeri.Name = "LotSeri";
            this.LotSeri.Width = 124;
            // 
            // StokAdet
            // 
            this.StokAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.StokAdet.HeaderText = "StokAdet";
            this.StokAdet.MinimumWidth = 8;
            this.StokAdet.Name = "StokAdet";
            this.StokAdet.Width = 112;
            // 
            // RafAdet
            // 
            this.RafAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RafAdet.HeaderText = "Raf Adet";
            this.RafAdet.MinimumWidth = 8;
            this.RafAdet.Name = "RafAdet";
            this.RafAdet.Width = 109;
            // 
            // StokDurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1616, 710);
            this.Controls.Add(this.splStokDurum);
            this.Name = "StokDurum";
            this.Text = "StokDurum";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StokDurum_Load);
            this.splStokDurum.Panel1.ResumeLayout(false);
            this.splStokDurum.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splStokDurum)).EndInit();
            this.splStokDurum.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeSube)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeKonsinye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListeUrunHareket)).EndInit();
            this.tcStokDurum.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListeStok1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splStokDurum;
        private System.Windows.Forms.DataGridView ListeStok;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.DataGridView ListeSube;
        private System.Windows.Forms.Splitter splitter4;
        private System.Windows.Forms.Splitter splitter3;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.DataGridView ListeKonsinye;
        private System.Windows.Forms.DataGridView ListeUrunHareket;
        private System.Windows.Forms.TabControl tcStokDurum;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn sBarkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sLot;
        private System.Windows.Forms.DataGridViewTextBoxColumn sStokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sRafAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sKonsinyeAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sSubeAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sUrunHareket;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SkTarih;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView ListeStok1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn StokAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn RafAdet;
    }
}