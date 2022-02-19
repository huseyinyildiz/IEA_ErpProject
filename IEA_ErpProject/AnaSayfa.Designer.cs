namespace IEA_ErpProject
{
    partial class AnaSayfa
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
            this.tabPGenel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlSol = new System.Windows.Forms.Panel();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.pnlSolUst = new System.Windows.Forms.Panel();
            this.btnSolUstCollapse = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnSolUstAra = new System.Windows.Forms.Button();
            this.txtSolUstAra = new System.Windows.Forms.TextBox();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.tabPGenel.SuspendLayout();
            this.pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.Panel2.SuspendLayout();
            this.scMenu.SuspendLayout();
            this.pnlSolUst.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPGenel
            // 
            this.tabPGenel.Controls.Add(this.tabPage1);
            this.tabPGenel.Controls.Add(this.tabPage2);
            this.tabPGenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPGenel.Location = new System.Drawing.Point(0, 0);
            this.tabPGenel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPGenel.Name = "tabPGenel";
            this.tabPGenel.SelectedIndex = 0;
            this.tabPGenel.Size = new System.Drawing.Size(963, 53);
            this.tabPGenel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(955, 27);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1015, 27);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yönetim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 53);
            this.splitter1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(963, 3);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlSol.Controls.Add(this.scMenu);
            this.pnlSol.Controls.Add(this.pnlSolUst);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 56);
            this.pnlSol.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(333, 446);
            this.pnlSol.TabIndex = 2;
            // 
            // scMenu
            // 
            this.scMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.Location = new System.Drawing.Point(0, 49);
            this.scMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.scMenu.Name = "scMenu";
            this.scMenu.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMenu.Panel1
            // 
            this.scMenu.Panel1.BackColor = System.Drawing.Color.DarkGray;
            this.scMenu.Panel1.Controls.Add(this.tvMenu);
            // 
            // scMenu.Panel2
            // 
            this.scMenu.Panel2.BackColor = System.Drawing.Color.DimGray;
            this.scMenu.Panel2.Controls.Add(this.btnUrunGiris);
            this.scMenu.Panel2.Controls.Add(this.btnBilgiGiris);
            this.scMenu.Size = new System.Drawing.Size(333, 397);
            this.scMenu.SplitterDistance = 197;
            this.scMenu.SplitterWidth = 3;
            this.scMenu.TabIndex = 4;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(329, 193);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.DoubleClick += new System.EventHandler(this.tvMenu_DoubleClick);
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.Location = new System.Drawing.Point(81, 10);
            this.btnUrunGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(71, 38);
            this.btnUrunGiris.TabIndex = 1;
            this.btnUrunGiris.Text = "Ürün İşlemleri";
            this.btnUrunGiris.UseVisualStyleBackColor = true;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.Location = new System.Drawing.Point(7, 9);
            this.btnBilgiGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(71, 40);
            this.btnBilgiGiris.TabIndex = 0;
            this.btnBilgiGiris.Text = "Bilgi Giriş İşlemleri";
            this.btnBilgiGiris.UseVisualStyleBackColor = true;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // pnlSolUst
            // 
            this.pnlSolUst.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnlSolUst.Controls.Add(this.btnSolUstCollapse);
            this.pnlSolUst.Controls.Add(this.lblMenu);
            this.pnlSolUst.Controls.Add(this.btnSolUstAra);
            this.pnlSolUst.Controls.Add(this.txtSolUstAra);
            this.pnlSolUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSolUst.Location = new System.Drawing.Point(0, 0);
            this.pnlSolUst.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlSolUst.Name = "pnlSolUst";
            this.pnlSolUst.Size = new System.Drawing.Size(333, 49);
            this.pnlSolUst.TabIndex = 4;
            this.pnlSolUst.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSolUst_Paint);
            // 
            // btnSolUstCollapse
            // 
            this.btnSolUstCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolUstCollapse.BackgroundImage = global::IEA_ErpProject.Properties.Resources.RightLeft2Red;
            this.btnSolUstCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolUstCollapse.Location = new System.Drawing.Point(311, 23);
            this.btnSolUstCollapse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSolUstCollapse.Name = "btnSolUstCollapse";
            this.btnSolUstCollapse.Size = new System.Drawing.Size(21, 16);
            this.btnSolUstCollapse.TabIndex = 3;
            this.btnSolUstCollapse.UseVisualStyleBackColor = true;
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(2, 21);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(309, 18);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "****";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSolUstAra
            // 
            this.btnSolUstAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolUstAra.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Ara32x32;
            this.btnSolUstAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSolUstAra.Location = new System.Drawing.Point(315, 3);
            this.btnSolUstAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSolUstAra.Name = "btnSolUstAra";
            this.btnSolUstAra.Size = new System.Drawing.Size(18, 16);
            this.btnSolUstAra.TabIndex = 1;
            this.btnSolUstAra.UseVisualStyleBackColor = true;
            // 
            // txtSolUstAra
            // 
            this.txtSolUstAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolUstAra.Location = new System.Drawing.Point(2, 2);
            this.txtSolUstAra.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSolUstAra.Name = "txtSolUstAra";
            this.txtSolUstAra.Size = new System.Drawing.Size(310, 20);
            this.txtSolUstAra.TabIndex = 0;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitter2.Location = new System.Drawing.Point(333, 56);
            this.splitter2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 446);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 502);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabPGenel);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.tabPGenel.ResumeLayout(false);
            this.pnlSol.ResumeLayout(false);
            this.scMenu.Panel1.ResumeLayout(false);
            this.scMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
            this.pnlSolUst.ResumeLayout(false);
            this.pnlSolUst.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPGenel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel pnlSol;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel pnlSolUst;
        private System.Windows.Forms.Button btnSolUstAra;
        private System.Windows.Forms.TextBox txtSolUstAra;
        private System.Windows.Forms.Button btnSolUstCollapse;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.SplitContainer scMenu;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Button btnBilgiGiris;
        private System.Windows.Forms.Button btnUrunGiris;
    }
}

