﻿namespace IEA_ErpProject
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
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.pnlSolUst = new System.Windows.Forms.Panel();
            this.txtSolUstAra = new System.Windows.Forms.TextBox();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnSolUstCollapse = new System.Windows.Forms.Button();
            this.btnSolUstAra = new System.Windows.Forms.Button();
            this.scMenu = new System.Windows.Forms.SplitContainer();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.btnBilgiGiris = new System.Windows.Forms.Button();
            this.btnUrunGiris = new System.Windows.Forms.Button();
            this.tabPGenel.SuspendLayout();
            this.pnlSol.SuspendLayout();
            this.pnlSolUst.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).BeginInit();
            this.scMenu.Panel1.SuspendLayout();
            this.scMenu.Panel2.SuspendLayout();
            this.scMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPGenel
            // 
            this.tabPGenel.Controls.Add(this.tabPage1);
            this.tabPGenel.Controls.Add(this.tabPage2);
            this.tabPGenel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabPGenel.Location = new System.Drawing.Point(0, 0);
            this.tabPGenel.Name = "tabPGenel";
            this.tabPGenel.SelectedIndex = 0;
            this.tabPGenel.Size = new System.Drawing.Size(1535, 81);
            this.tabPGenel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1527, 48);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Genel";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1527, 48);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Yönetim";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.ControlText;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 81);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1535, 4);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // pnlSol
            // 
            this.pnlSol.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlSol.Controls.Add(this.scMenu);
            this.pnlSol.Controls.Add(this.pnlSolUst);
            this.pnlSol.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSol.Location = new System.Drawing.Point(0, 85);
            this.pnlSol.Name = "pnlSol";
            this.pnlSol.Size = new System.Drawing.Size(499, 687);
            this.pnlSol.TabIndex = 2;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.Desktop;
            this.splitter2.Location = new System.Drawing.Point(499, 85);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(4, 687);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
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
            this.pnlSolUst.Name = "pnlSolUst";
            this.pnlSolUst.Size = new System.Drawing.Size(499, 75);
            this.pnlSolUst.TabIndex = 4;
            this.pnlSolUst.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlSolUst_Paint);
            // 
            // txtSolUstAra
            // 
            this.txtSolUstAra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolUstAra.Location = new System.Drawing.Point(3, 3);
            this.txtSolUstAra.Name = "txtSolUstAra";
            this.txtSolUstAra.Size = new System.Drawing.Size(463, 26);
            this.txtSolUstAra.TabIndex = 0;
            // 
            // lblMenu
            // 
            this.lblMenu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMenu.Location = new System.Drawing.Point(3, 32);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(463, 28);
            this.lblMenu.TabIndex = 2;
            this.lblMenu.Text = "****";
            this.lblMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSolUstCollapse
            // 
            this.btnSolUstCollapse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolUstCollapse.BackgroundImage = global::IEA_ErpProject.Properties.Resources.RightLeft2Red;
            this.btnSolUstCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolUstCollapse.Location = new System.Drawing.Point(467, 35);
            this.btnSolUstCollapse.Name = "btnSolUstCollapse";
            this.btnSolUstCollapse.Size = new System.Drawing.Size(32, 25);
            this.btnSolUstCollapse.TabIndex = 3;
            this.btnSolUstCollapse.UseVisualStyleBackColor = true;
            // 
            // btnSolUstAra
            // 
            this.btnSolUstAra.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSolUstAra.BackgroundImage = global::IEA_ErpProject.Properties.Resources.Ara32x32;
            this.btnSolUstAra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSolUstAra.Location = new System.Drawing.Point(472, 5);
            this.btnSolUstAra.Name = "btnSolUstAra";
            this.btnSolUstAra.Size = new System.Drawing.Size(27, 24);
            this.btnSolUstAra.TabIndex = 1;
            this.btnSolUstAra.UseVisualStyleBackColor = true;
            // 
            // scMenu
            // 
            this.scMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.scMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMenu.Location = new System.Drawing.Point(0, 75);
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
            this.scMenu.Size = new System.Drawing.Size(499, 612);
            this.scMenu.SplitterDistance = 304;
            this.scMenu.TabIndex = 4;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Location = new System.Drawing.Point(0, 0);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(495, 300);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.DoubleClick += new System.EventHandler(this.tvMenu_DoubleClick);
            // 
            // btnBilgiGiris
            // 
            this.btnBilgiGiris.Location = new System.Drawing.Point(10, 14);
            this.btnBilgiGiris.Name = "btnBilgiGiris";
            this.btnBilgiGiris.Size = new System.Drawing.Size(106, 61);
            this.btnBilgiGiris.TabIndex = 0;
            this.btnBilgiGiris.Text = "Bilgi Giriş İşlemleri";
            this.btnBilgiGiris.UseVisualStyleBackColor = true;
            this.btnBilgiGiris.Click += new System.EventHandler(this.btnBilgiGiris_Click);
            // 
            // btnUrunGiris
            // 
            this.btnUrunGiris.Location = new System.Drawing.Point(122, 16);
            this.btnUrunGiris.Name = "btnUrunGiris";
            this.btnUrunGiris.Size = new System.Drawing.Size(107, 59);
            this.btnUrunGiris.TabIndex = 1;
            this.btnUrunGiris.Text = "Ürün İşlemleri";
            this.btnUrunGiris.UseVisualStyleBackColor = true;
            this.btnUrunGiris.Click += new System.EventHandler(this.btnUrunGiris_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1535, 772);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.pnlSol);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.tabPGenel);
            this.IsMdiContainer = true;
            this.Name = "AnaSayfa";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfa_Load);
            this.tabPGenel.ResumeLayout(false);
            this.pnlSol.ResumeLayout(false);
            this.pnlSolUst.ResumeLayout(false);
            this.pnlSolUst.PerformLayout();
            this.scMenu.Panel1.ResumeLayout(false);
            this.scMenu.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMenu)).EndInit();
            this.scMenu.ResumeLayout(false);
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

