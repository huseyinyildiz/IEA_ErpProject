namespace IEA_ErpProject.KonsinyeIslemleri.Giris
{
    partial class KonsinyeGonderim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlListe = new System.Windows.Forms.Panel();
            this.etiketId = new System.Windows.Forms.Label();
            this.btnRowsDelete = new System.Windows.Forms.Button();
            this.TxtKonGonderimAciklama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtGonderimTarih = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtKonGonderimTur = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtCariAdi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCariTur = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtKonGonderimId = new System.Windows.Forms.TextBox();
            this.pcUrunGiris = new System.Windows.Forms.SplitContainer();
            this.pnlUst = new System.Windows.Forms.Panel();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sira = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Barkod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LotSeri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SevkAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Not = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrunId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uts = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SKTarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Durum = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.BtnAddListeRow = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.pnlListe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcUrunGiris)).BeginInit();
            this.pcUrunGiris.Panel1.SuspendLayout();
            this.pcUrunGiris.Panel2.SuspendLayout();
            this.pcUrunGiris.SuspendLayout();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlListe
            // 
            this.pnlListe.BackColor = System.Drawing.Color.IndianRed;
            this.pnlListe.Controls.Add(this.etiketId);
            this.pnlListe.Controls.Add(this.btnRowsDelete);
            this.pnlListe.Controls.Add(this.BtnAddListeRow);
            this.pnlListe.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlListe.Location = new System.Drawing.Point(0, 0);
            this.pnlListe.Name = "pnlListe";
            this.pnlListe.Size = new System.Drawing.Size(1221, 46);
            this.pnlListe.TabIndex = 2;
            // 
            // etiketId
            // 
            this.etiketId.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.etiketId.Location = new System.Drawing.Point(510, 7);
            this.etiketId.Name = "etiketId";
            this.etiketId.Size = new System.Drawing.Size(88, 33);
            this.etiketId.TabIndex = 22;
            this.etiketId.Text = "***";
            this.etiketId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRowsDelete
            // 
            this.btnRowsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRowsDelete.Location = new System.Drawing.Point(1050, 7);
            this.btnRowsDelete.Name = "btnRowsDelete";
            this.btnRowsDelete.Size = new System.Drawing.Size(88, 33);
            this.btnRowsDelete.TabIndex = 1;
            this.btnRowsDelete.Text = "Satır Sil";
            this.btnRowsDelete.UseVisualStyleBackColor = true;
            // 
            // TxtKonGonderimAciklama
            // 
            this.TxtKonGonderimAciklama.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonGonderimAciklama.Location = new System.Drawing.Point(0, 379);
            this.TxtKonGonderimAciklama.Multiline = true;
            this.TxtKonGonderimAciklama.Name = "TxtKonGonderimAciklama";
            this.TxtKonGonderimAciklama.Size = new System.Drawing.Size(375, 154);
            this.TxtKonGonderimAciklama.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(0, 347);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(375, 32);
            this.label8.TabIndex = 33;
            this.label8.Text = "Açıklama";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtGonderimTarih
            // 
            this.TxtGonderimTarih.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtGonderimTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TxtGonderimTarih.Location = new System.Drawing.Point(0, 321);
            this.TxtGonderimTarih.Name = "TxtGonderimTarih";
            this.TxtGonderimTarih.Size = new System.Drawing.Size(375, 26);
            this.TxtGonderimTarih.TabIndex = 32;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(0, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(375, 32);
            this.label7.TabIndex = 31;
            this.label7.Text = "Gonderim Tarihi";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKonGonderimTur
            // 
            this.TxtKonGonderimTur.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonGonderimTur.FormattingEnabled = true;
            this.TxtKonGonderimTur.Items.AddRange(new object[] {
            "Normal Giris",
            "Muhtelif Giris"});
            this.TxtKonGonderimTur.Location = new System.Drawing.Point(0, 261);
            this.TxtKonGonderimTur.Name = "TxtKonGonderimTur";
            this.TxtKonGonderimTur.Size = new System.Drawing.Size(375, 28);
            this.TxtKonGonderimTur.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(0, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(375, 32);
            this.label5.TabIndex = 27;
            this.label5.Text = "Konsinye Gonderim Turu";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCariAdi
            // 
            this.TxtCariAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCariAdi.Location = new System.Drawing.Point(0, 150);
            this.TxtCariAdi.Multiline = true;
            this.TxtCariAdi.Name = "TxtCariAdi";
            this.TxtCariAdi.Size = new System.Drawing.Size(375, 79);
            this.TxtCariAdi.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(0, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 32);
            this.label4.TabIndex = 25;
            this.label4.Text = "Cari Adı";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCariTur
            // 
            this.TxtCariTur.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtCariTur.FormattingEnabled = true;
            this.TxtCariTur.Items.AddRange(new object[] {
            "Doktor",
            "Firma",
            "Hastane",
            "Personel",
            "Diger"});
            this.TxtCariTur.Location = new System.Drawing.Point(0, 90);
            this.TxtCariTur.Name = "TxtCariTur";
            this.TxtCariTur.Size = new System.Drawing.Size(375, 28);
            this.TxtCariTur.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(0, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 32);
            this.label3.TabIndex = 23;
            this.label3.Text = "Cari Türü";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Konsinye Gonderim No";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Sira,
            this.Barkod,
            this.UrunKodu,
            this.LotSeri,
            this.RAdet,
            this.SevkAdet,
            this.Not,
            this.UrunId,
            this.Uts,
            this.UTarih,
            this.SKTarihi,
            this.Durum});
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 46);
            this.Liste.Name = "Liste";
            this.Liste.RowHeadersVisible = false;
            this.Liste.RowHeadersWidth = 62;
            this.Liste.RowTemplate.Height = 28;
            this.Liste.Size = new System.Drawing.Size(1221, 737);
            this.Liste.TabIndex = 0;
            this.Liste.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_CellEnter);
            this.Liste.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Liste_EditingControlShowing);
            this.Liste.SelectionChanged += new System.EventHandler(this.Liste_SelectionChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(610, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 64);
            this.label1.TabIndex = 20;
            this.label1.Text = "Konsinye Gonderim";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtKonGonderimId
            // 
            this.TxtKonGonderimId.Dock = System.Windows.Forms.DockStyle.Top;
            this.TxtKonGonderimId.Location = new System.Drawing.Point(0, 32);
            this.TxtKonGonderimId.Name = "TxtKonGonderimId";
            this.TxtKonGonderimId.Size = new System.Drawing.Size(375, 26);
            this.TxtKonGonderimId.TabIndex = 22;
            // 
            // pcUrunGiris
            // 
            this.pcUrunGiris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcUrunGiris.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcUrunGiris.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.pcUrunGiris.Location = new System.Drawing.Point(0, 74);
            this.pcUrunGiris.Name = "pcUrunGiris";
            // 
            // pcUrunGiris.Panel1
            // 
            this.pcUrunGiris.Panel1.Controls.Add(this.Liste);
            this.pcUrunGiris.Panel1.Controls.Add(this.pnlListe);
            // 
            // pcUrunGiris.Panel2
            // 
            this.pcUrunGiris.Panel2.BackColor = System.Drawing.Color.IndianRed;
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtKonGonderimAciklama);
            this.pcUrunGiris.Panel2.Controls.Add(this.label8);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtGonderimTarih);
            this.pcUrunGiris.Panel2.Controls.Add(this.label7);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtKonGonderimTur);
            this.pcUrunGiris.Panel2.Controls.Add(this.label5);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtCariAdi);
            this.pcUrunGiris.Panel2.Controls.Add(this.label4);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtCariTur);
            this.pcUrunGiris.Panel2.Controls.Add(this.label3);
            this.pcUrunGiris.Panel2.Controls.Add(this.TxtKonGonderimId);
            this.pcUrunGiris.Panel2.Controls.Add(this.label2);
            this.pcUrunGiris.Size = new System.Drawing.Size(1608, 787);
            this.pcUrunGiris.SplitterDistance = 1225;
            this.pcUrunGiris.TabIndex = 3;
            // 
            // pnlUst
            // 
            this.pnlUst.BackColor = System.Drawing.Color.IndianRed;
            this.pnlUst.Controls.Add(this.btnPrint);
            this.pnlUst.Controls.Add(this.label1);
            this.pnlUst.Controls.Add(this.btnKaydet);
            this.pnlUst.Controls.Add(this.btnGuncelle);
            this.pnlUst.Controls.Add(this.btnSil);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Controls.Add(this.btnTemizle);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Location = new System.Drawing.Point(0, 0);
            this.pnlUst.Name = "pnlUst";
            this.pnlUst.Size = new System.Drawing.Size(1608, 74);
            this.pnlUst.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 8;
            this.Id.Name = "Id";
            this.Id.Visible = false;
            this.Id.Width = 29;
            // 
            // Sira
            // 
            this.Sira.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Sira.HeaderText = "Sira";
            this.Sira.MinimumWidth = 8;
            this.Sira.Name = "Sira";
            this.Sira.Visible = false;
            this.Sira.Width = 43;
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
            this.UrunKodu.HeaderText = "UrunKodu";
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
            // RAdet
            // 
            this.RAdet.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.RAdet.HeaderText = "Raf Adet";
            this.RAdet.MinimumWidth = 8;
            this.RAdet.Name = "RAdet";
            this.RAdet.ReadOnly = true;
            this.RAdet.Width = 109;
            // 
            // SevkAdet
            // 
            this.SevkAdet.HeaderText = "SevkAdet";
            this.SevkAdet.MinimumWidth = 8;
            this.SevkAdet.Name = "SevkAdet";
            this.SevkAdet.Width = 150;
            // 
            // Not
            // 
            this.Not.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle4.NullValue = " ";
            this.Not.DefaultCellStyle = dataGridViewCellStyle4;
            this.Not.HeaderText = "Not";
            this.Not.MinimumWidth = 8;
            this.Not.Name = "Not";
            this.Not.Width = 70;
            // 
            // UrunId
            // 
            this.UrunId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UrunId.HeaderText = "UrunId";
            this.UrunId.MinimumWidth = 8;
            this.UrunId.Name = "UrunId";
            this.UrunId.Visible = false;
            this.UrunId.Width = 94;
            // 
            // Uts
            // 
            this.Uts.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Uts.FalseValue = "False";
            this.Uts.HeaderText = "UTS";
            this.Uts.MinimumWidth = 8;
            this.Uts.Name = "Uts";
            this.Uts.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Uts.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Uts.TrueValue = "True";
            this.Uts.Width = 77;
            // 
            // UTarih
            // 
            this.UTarih.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UTarih.HeaderText = "Üretim Tarihi";
            this.UTarih.MinimumWidth = 8;
            this.UTarih.Name = "UTarih";
            this.UTarih.Width = 134;
            // 
            // SKTarihi
            // 
            this.SKTarihi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SKTarihi.HeaderText = "SKT";
            this.SKTarihi.MinimumWidth = 8;
            this.SKTarihi.Name = "SKTarihi";
            this.SKTarihi.Width = 75;
            // 
            // Durum
            // 
            this.Durum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Durum.HeaderText = "Durum";
            this.Durum.MinimumWidth = 8;
            this.Durum.Name = "Durum";
            this.Durum.Visible = false;
            this.Durum.Width = 63;
            // 
            // BtnAddListeRow
            // 
            this.BtnAddListeRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddListeRow.BackgroundImage = global::IEA_ErpProject.Properties.Resources.plus;
            this.BtnAddListeRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnAddListeRow.Location = new System.Drawing.Point(1144, 3);
            this.BtnAddListeRow.Name = "BtnAddListeRow";
            this.BtnAddListeRow.Size = new System.Drawing.Size(50, 37);
            this.BtnAddListeRow.TabIndex = 0;
            this.BtnAddListeRow.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::IEA_ErpProject.Properties.Resources.print_flat;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(241, 12);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 49);
            this.btnPrint.TabIndex = 21;
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Save_icon64x64;
            this.btnKaydet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKaydet.Location = new System.Drawing.Point(17, 13);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(50, 49);
            this.btnKaydet.TabIndex = 19;
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Update32x32;
            this.btnGuncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGuncelle.Location = new System.Drawing.Point(73, 13);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(50, 49);
            this.btnGuncelle.TabIndex = 18;
            this.btnGuncelle.UseVisualStyleBackColor = true;
            // 
            // btnSil
            // 
            this.btnSil.BackgroundImage = global::IEA_ErpProject.Properties.Resources.cop24x24;
            this.btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSil.Location = new System.Drawing.Point(129, 13);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(50, 49);
            this.btnSil.TabIndex = 17;
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.BackgroundImage = global::IEA_ErpProject.Properties.Resources.exit_64;
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Location = new System.Drawing.Point(1536, 13);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(50, 49);
            this.btnKapat.TabIndex = 15;
            this.btnKapat.UseVisualStyleBackColor = true;
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackgroundImage = global::IEA_ErpProject.Properties.Resources.png_transparent_dustpan_computer_icons_iconfinder_clear_miscellaneous_angle_photography;
            this.btnTemizle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTemizle.Location = new System.Drawing.Point(185, 13);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(50, 49);
            this.btnTemizle.TabIndex = 16;
            this.btnTemizle.UseVisualStyleBackColor = true;
            // 
            // KonsinyeGonderim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1608, 861);
            this.Controls.Add(this.pcUrunGiris);
            this.Controls.Add(this.pnlUst);
            this.Name = "KonsinyeGonderim";
            this.Text = "KonsinyeGiris";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KonsinyeGiris_Load);
            this.pnlListe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.pcUrunGiris.Panel1.ResumeLayout(false);
            this.pcUrunGiris.Panel2.ResumeLayout(false);
            this.pcUrunGiris.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcUrunGiris)).EndInit();
            this.pcUrunGiris.ResumeLayout(false);
            this.pnlUst.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlListe;
        private System.Windows.Forms.Label etiketId;
        private System.Windows.Forms.Button btnRowsDelete;
        private System.Windows.Forms.Button BtnAddListeRow;
        private System.Windows.Forms.TextBox TxtKonGonderimAciklama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker TxtGonderimTarih;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TxtKonGonderimTur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtCariAdi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox TxtCariTur;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.TextBox TxtKonGonderimId;
        private System.Windows.Forms.SplitContainer pcUrunGiris;
        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sira;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barkod;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn LotSeri;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn SevkAdet;
        private System.Windows.Forms.DataGridViewTextBoxColumn Not;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrunId;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Uts;
        private System.Windows.Forms.DataGridViewTextBoxColumn UTarih;
        private System.Windows.Forms.DataGridViewTextBoxColumn SKTarihi;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Durum;
        public System.Windows.Forms.DataGridView Liste;
    }
}