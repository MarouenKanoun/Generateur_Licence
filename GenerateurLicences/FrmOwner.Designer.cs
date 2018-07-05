using System.Drawing;

namespace GenerateurLicences
{
    partial class FrmOwner
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOwner));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.DockingSkin = new DevExpress.XtraBars.BarAndDockingController(this.components);
            this.BtnAcceuil = new DevExpress.XtraBars.BarButtonItem();
            this.BtnDetails = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.TabbedMdiOwner = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockingSkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabbedMdiOwner)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ApplicationIcon = global::GenerateurLicences.Properties.Resources.Logo_laposte;
            this.ribbonControl1.Controller = this.DockingSkin;
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.BtnAcceuil,
            this.BtnDetails});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 3;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbonControl1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
            this.ribbonControl1.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbonControl1.Size = new System.Drawing.Size(554, 148);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            this.ribbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            // 
            // DockingSkin
            // 
            this.DockingSkin.LookAndFeel.SkinName = "McSkin";
            this.DockingSkin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.DockingSkin.PropertiesBar.AllowLinkLighting = false;
            this.DockingSkin.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.DockingSkin.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // BtnAcceuil
            // 
            this.BtnAcceuil.Caption = "Acceuil";
            this.BtnAcceuil.Id = 1;
            this.BtnAcceuil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnAcceuil.ImageOptions.Image")));
            this.BtnAcceuil.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnAcceuil.ImageOptions.LargeImage")));
            this.BtnAcceuil.Name = "BtnAcceuil";
            this.BtnAcceuil.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnAcceuil_ItemClick);
            // 
            // BtnDetails
            // 
            this.BtnDetails.Caption = "Details";
            this.BtnDetails.Id = 2;
            this.BtnDetails.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnDetails.ImageOptions.Image")));
            this.BtnDetails.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("BtnDetails.ImageOptions.LargeImage")));
            this.BtnDetails.Name = "BtnDetails";
            this.BtnDetails.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BtnDetails_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "De Base";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.AllowTextClipping = false;
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnAcceuil);
            this.ribbonPageGroup1.ItemLinks.Add(this.BtnDetails);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Informations de Base\r\n";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 441);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(554, 27);
            // 
            // TabbedMdiOwner
            // 
            this.TabbedMdiOwner.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.TabbedMdiOwner.Appearance.Options.UseBackColor = true;
            this.TabbedMdiOwner.Controller = this.DockingSkin;
            this.TabbedMdiOwner.MdiParent = this;
            // 
            // FrmOwner
            // 
            this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.False;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 468);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmOwner";
            this.Ribbon = this.ribbonControl1;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Start";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockingSkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabbedMdiOwner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarAndDockingController DockingSkin;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraBars.BarButtonItem BtnAcceuil;
        private DevExpress.XtraBars.BarButtonItem BtnDetails;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager TabbedMdiOwner;
    }
}

