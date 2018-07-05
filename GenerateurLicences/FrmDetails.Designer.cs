using System.Drawing;

namespace GenerateurLicences
{
    partial class FrmDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDetails));
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.GropLicences = new DevExpress.XtraEditors.RadioGroup();
            this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.DateExpirationDelais = new DevExpress.XtraEditors.DateEdit();
            this.DebutLicenceDetails = new DevExpress.XtraEditors.DateEdit();
            this.NomClientDetail = new DevExpress.XtraEditors.TextEdit();
            this.NumeroLicnceDetails = new DevExpress.XtraEditors.TextEdit();
            this.JourRestant = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtZipeCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.CodeClientDetails = new DevExpress.XtraEditors.TextEdit();
            this.BtnRenew = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.PicLicence3 = new DevExpress.XtraEditors.PictureEdit();
            this.PicLicence2 = new DevExpress.XtraEditors.PictureEdit();
            this.PicLicence1 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSave = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.BtnImprimer = new DevExpress.XtraEditors.SimpleButton();
            this.BtnClose = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GropLicences.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateExpirationDelais.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateExpirationDelais.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebutLicenceDetails.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebutLicenceDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomClientDetail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroLicnceDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JourRestant.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeClientDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicence3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicence2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicence1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.layoutControl2.Controls.Add(this.GropLicences);
            this.layoutControl2.Location = new System.Drawing.Point(491, 273);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(374, 40, 450, 400);
            this.layoutControl2.Root = this.layoutControlGroup4;
            this.layoutControl2.Size = new System.Drawing.Size(316, 52);
            this.layoutControl2.TabIndex = 50;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // GropLicences
            // 
            this.GropLicences.Location = new System.Drawing.Point(12, 12);
            this.GropLicences.Name = "GropLicences";
            this.GropLicences.Properties.AllowFocused = false;
            this.GropLicences.Properties.Appearance.BackColor = System.Drawing.Color.Lime;
            this.GropLicences.Properties.Appearance.Options.UseBackColor = true;
            this.GropLicences.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.GropLicences.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.GropLicences.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Licence1", true, 30),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Licence2", true, 90),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(null, "Licence3", true, 360)});
            this.GropLicences.Size = new System.Drawing.Size(292, 28);
            this.GropLicences.StyleController = this.layoutControl2;
            this.GropLicences.TabIndex = 0;
            this.GropLicences.SelectedIndexChanged += new System.EventHandler(this.GropLicences_SelectedIndexChanged);
            // 
            // layoutControlGroup4
            // 
            this.layoutControlGroup4.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup4.GroupBordersVisible = false;
            this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7});
            this.layoutControlGroup4.Name = "Root";
            this.layoutControlGroup4.Size = new System.Drawing.Size(316, 52);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.GropLicences;
            this.layoutControlItem7.CustomizationFormText = "Licences :";
            this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(296, 32);
            this.layoutControlItem7.Text = "Licences :";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // labelControl4
            // 
            this.labelControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Times New Roman", 35F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Appearance.Options.UseTextOptions = true;
            this.labelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(0, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(808, 81);
            this.labelControl4.TabIndex = 47;
            this.labelControl4.Text = "Details Licence Client";
            // 
            // DateExpirationDelais
            // 
            this.DateExpirationDelais.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DateExpirationDelais.EditValue = null;
            this.DateExpirationDelais.Location = new System.Drawing.Point(257, 419);
            this.DateExpirationDelais.Name = "DateExpirationDelais";
            this.DateExpirationDelais.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.DateExpirationDelais.Properties.Appearance.Options.UseFont = true;
            this.DateExpirationDelais.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.DateExpirationDelais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateExpirationDelais.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DateExpirationDelais.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.DateExpirationDelais.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DateExpirationDelais.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.DateExpirationDelais.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DateExpirationDelais.Properties.Mask.EditMask = "";
            this.DateExpirationDelais.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.DateExpirationDelais.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DateExpirationDelais.Size = new System.Drawing.Size(239, 30);
            this.DateExpirationDelais.TabIndex = 28;
            // 
            // DebutLicenceDetails
            // 
            this.DebutLicenceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DebutLicenceDetails.EditValue = "";
            this.DebutLicenceDetails.Location = new System.Drawing.Point(12, 419);
            this.DebutLicenceDetails.Name = "DebutLicenceDetails";
            this.DebutLicenceDetails.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.DebutLicenceDetails.Properties.Appearance.Options.UseFont = true;
            this.DebutLicenceDetails.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.DebutLicenceDetails.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DebutLicenceDetails.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DebutLicenceDetails.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.DebutLicenceDetails.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DebutLicenceDetails.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.DebutLicenceDetails.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.DebutLicenceDetails.Properties.Mask.EditMask = "";
            this.DebutLicenceDetails.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.DebutLicenceDetails.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.DebutLicenceDetails.Size = new System.Drawing.Size(239, 30);
            this.DebutLicenceDetails.TabIndex = 29;
            // 
            // NomClientDetail
            // 
            this.NomClientDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NomClientDetail.Enabled = false;
            this.NomClientDetail.Location = new System.Drawing.Point(12, 284);
            this.NomClientDetail.Name = "NomClientDetail";
            this.NomClientDetail.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.NomClientDetail.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.NomClientDetail.Properties.Appearance.Options.UseFont = true;
            this.NomClientDetail.Properties.Appearance.Options.UseForeColor = true;
            this.NomClientDetail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.NomClientDetail.Size = new System.Drawing.Size(484, 30);
            this.NomClientDetail.TabIndex = 26;
            // 
            // NumeroLicnceDetails
            // 
            this.NumeroLicnceDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NumeroLicnceDetails.Enabled = false;
            this.NumeroLicnceDetails.Location = new System.Drawing.Point(502, 351);
            this.NumeroLicnceDetails.Name = "NumeroLicnceDetails";
            this.NumeroLicnceDetails.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.NumeroLicnceDetails.Properties.Appearance.Options.UseFont = true;
            this.NumeroLicnceDetails.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.NumeroLicnceDetails.Size = new System.Drawing.Size(294, 30);
            this.NumeroLicnceDetails.TabIndex = 27;
            this.NumeroLicnceDetails.EditValueChanged += new System.EventHandler(this.NumeroLicnceDetails_EditValueChanged);
            // 
            // JourRestant
            // 
            this.JourRestant.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.JourRestant.Enabled = false;
            this.JourRestant.Location = new System.Drawing.Point(502, 419);
            this.JourRestant.Name = "JourRestant";
            this.JourRestant.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.JourRestant.Properties.Appearance.Options.UseFont = true;
            this.JourRestant.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.JourRestant.Size = new System.Drawing.Size(294, 30);
            this.JourRestant.TabIndex = 30;
            this.JourRestant.EditValueChanged += new System.EventHandler(this.JourRestant_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(12, 255);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 23);
            this.labelControl1.TabIndex = 32;
            this.labelControl1.Text = "Client ";
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(257, 322);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 23);
            this.labelControl2.TabIndex = 33;
            this.labelControl2.Text = "Code Client";
            // 
            // labelControl3
            // 
            this.labelControl3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(502, 255);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(133, 23);
            this.labelControl3.TabIndex = 34;
            this.labelControl3.Text = "Type de Licence";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Appearance.Options.UseForeColor = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 390);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(165, 23);
            this.labelControl5.TabIndex = 35;
            this.labelControl5.Text = "Data Debut Licence";
            // 
            // labelControl6
            // 
            this.labelControl6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Appearance.Options.UseForeColor = true;
            this.labelControl6.Location = new System.Drawing.Point(502, 390);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(208, 23);
            this.labelControl6.TabIndex = 36;
            this.labelControl6.Text = "Nombre de Jour Restant ";
            // 
            // labelControl7
            // 
            this.labelControl7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Appearance.Options.UseForeColor = true;
            this.labelControl7.Location = new System.Drawing.Point(502, 322);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(199, 23);
            this.labelControl7.TabIndex = 37;
            this.labelControl7.Text = "Numero Licence Client ";
            // 
            // labelControl8
            // 
            this.labelControl8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Appearance.Options.UseForeColor = true;
            this.labelControl8.Location = new System.Drawing.Point(257, 390);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(144, 23);
            this.labelControl8.TabIndex = 38;
            this.labelControl8.Text = "Date Fin Licence";
            // 
            // txtZipeCode
            // 
            this.txtZipeCode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtZipeCode.Enabled = false;
            this.txtZipeCode.Location = new System.Drawing.Point(12, 351);
            this.txtZipeCode.Name = "txtZipeCode";
            this.txtZipeCode.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.txtZipeCode.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.txtZipeCode.Properties.Appearance.Options.UseFont = true;
            this.txtZipeCode.Properties.Appearance.Options.UseForeColor = true;
            this.txtZipeCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtZipeCode.Size = new System.Drawing.Size(239, 30);
            this.txtZipeCode.TabIndex = 42;
            // 
            // labelControl9
            // 
            this.labelControl9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.ForeColor = System.Drawing.Color.Green;
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Appearance.Options.UseForeColor = true;
            this.labelControl9.Location = new System.Drawing.Point(12, 320);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(84, 23);
            this.labelControl9.TabIndex = 43;
            this.labelControl9.Text = "Zipe Code";
            // 
            // CodeClientDetails
            // 
            this.CodeClientDetails.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CodeClientDetails.Enabled = false;
            this.CodeClientDetails.Location = new System.Drawing.Point(257, 351);
            this.CodeClientDetails.Name = "CodeClientDetails";
            this.CodeClientDetails.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.CodeClientDetails.Properties.Appearance.ForeColor = System.Drawing.Color.Red;
            this.CodeClientDetails.Properties.Appearance.Options.UseFont = true;
            this.CodeClientDetails.Properties.Appearance.Options.UseForeColor = true;
            this.CodeClientDetails.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.CodeClientDetails.Size = new System.Drawing.Size(239, 30);
            this.CodeClientDetails.TabIndex = 45;
            // 
            // BtnRenew
            // 
            this.BtnRenew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRenew.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRenew.ImageOptions.Image")));
            this.BtnRenew.Location = new System.Drawing.Point(407, 455);
            this.BtnRenew.Name = "BtnRenew";
            this.BtnRenew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnRenew.Size = new System.Drawing.Size(125, 40);
            this.BtnRenew.TabIndex = 55;
            this.BtnRenew.Text = "Renew Licence";
            this.BtnRenew.Click += new System.EventHandler(this.BtnRenew_Click);
            // 
            // BtnSearch
            // 
            this.BtnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSearch.ImageOptions.Image")));
            this.BtnSearch.Location = new System.Drawing.Point(276, 455);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnSearch.Size = new System.Drawing.Size(125, 40);
            this.BtnSearch.TabIndex = 54;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // PicLicence3
            // 
            this.PicLicence3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicLicence3.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicLicence3.EditValue = global::GenerateurLicences.Properties.Resources.Licence3;
            this.PicLicence3.Location = new System.Drawing.Point(757, 287);
            this.PicLicence3.Name = "PicLicence3";
            this.PicLicence3.Properties.AllowFocused = false;
            this.PicLicence3.Properties.Appearance.BackColor = System.Drawing.Color.Lime;
            this.PicLicence3.Properties.Appearance.Options.UseBackColor = true;
            this.PicLicence3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PicLicence3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicLicence3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PicLicence3.Size = new System.Drawing.Size(24, 24);
            this.PicLicence3.TabIndex = 53;
            // 
            // PicLicence2
            // 
            this.PicLicence2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicLicence2.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicLicence2.EditValue = global::GenerateurLicences.Properties.Resources.Licence2;
            this.PicLicence2.Location = new System.Drawing.Point(663, 287);
            this.PicLicence2.Name = "PicLicence2";
            this.PicLicence2.Properties.AllowFocused = false;
            this.PicLicence2.Properties.Appearance.BackColor = System.Drawing.Color.Lime;
            this.PicLicence2.Properties.Appearance.Options.UseBackColor = true;
            this.PicLicence2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PicLicence2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicLicence2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PicLicence2.Size = new System.Drawing.Size(24, 24);
            this.PicLicence2.TabIndex = 52;
            // 
            // PicLicence1
            // 
            this.PicLicence1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PicLicence1.Cursor = System.Windows.Forms.Cursors.Default;
            this.PicLicence1.EditValue = global::GenerateurLicences.Properties.Resources.Licence1;
            this.PicLicence1.Location = new System.Drawing.Point(569, 287);
            this.PicLicence1.Name = "PicLicence1";
            this.PicLicence1.Properties.AllowFocused = false;
            this.PicLicence1.Properties.Appearance.BackColor = System.Drawing.Color.Lime;
            this.PicLicence1.Properties.Appearance.Options.UseBackColor = true;
            this.PicLicence1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PicLicence1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.PicLicence1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.PicLicence1.Size = new System.Drawing.Size(24, 24);
            this.PicLicence1.TabIndex = 51;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnRefresh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.ImageOptions.Image")));
            this.BtnRefresh.Location = new System.Drawing.Point(669, 455);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnRefresh.Size = new System.Drawing.Size(125, 40);
            this.BtnRefresh.TabIndex = 49;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnSave.Enabled = false;
            this.BtnSave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSave.ImageOptions.Image")));
            this.BtnSave.Location = new System.Drawing.Point(145, 455);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnSave.Size = new System.Drawing.Size(125, 40);
            this.BtnSave.TabIndex = 48;
            this.BtnSave.Text = "Sauvegarder";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureEdit1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(294, 25);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(226, 152);
            this.pictureEdit1.TabIndex = 46;
            // 
            // BtnImprimer
            // 
            this.BtnImprimer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnImprimer.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnImprimer.ImageOptions.Image")));
            this.BtnImprimer.Location = new System.Drawing.Point(538, 455);
            this.BtnImprimer.Name = "BtnImprimer";
            this.BtnImprimer.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnImprimer.Size = new System.Drawing.Size(125, 40);
            this.BtnImprimer.TabIndex = 44;
            this.BtnImprimer.Text = "Imprimer";
            this.BtnImprimer.Click += new System.EventHandler(this.BtnImprimer_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnClose.ImageOptions.Image")));
            this.BtnClose.Location = new System.Drawing.Point(14, 455);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.BtnClose.Size = new System.Drawing.Size(125, 40);
            this.BtnClose.TabIndex = 41;
            this.BtnClose.Text = "Sortie\r\n";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // FrmDetails
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 524);
            this.Controls.Add(this.BtnRenew);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.PicLicence3);
            this.Controls.Add(this.PicLicence2);
            this.Controls.Add(this.PicLicence1);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.CodeClientDetails);
            this.Controls.Add(this.BtnImprimer);
            this.Controls.Add(this.labelControl9);
            this.Controls.Add(this.txtZipeCode);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.JourRestant);
            this.Controls.Add(this.NumeroLicnceDetails);
            this.Controls.Add(this.NomClientDetail);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.DebutLicenceDetails);
            this.Controls.Add(this.DateExpirationDelais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "McSkin";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetails";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Shown += new System.EventHandler(this.FrmDetails_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GropLicences.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateExpirationDelais.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DateExpirationDelais.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebutLicenceDetails.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebutLicenceDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NomClientDetail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumeroLicnceDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JourRestant.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CodeClientDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicence3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicence2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLicence1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.RadioGroup GropLicences;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit DateExpirationDelais;
        private DevExpress.XtraEditors.DateEdit DebutLicenceDetails;
        private DevExpress.XtraEditors.TextEdit NomClientDetail;
        private DevExpress.XtraEditors.TextEdit NumeroLicnceDetails;
        private DevExpress.XtraEditors.TextEdit JourRestant;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton BtnClose;
        private DevExpress.XtraEditors.TextEdit txtZipeCode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.SimpleButton BtnImprimer;
        private DevExpress.XtraEditors.TextEdit CodeClientDetails;
        private DevExpress.XtraEditors.SimpleButton BtnSave;
        private DevExpress.XtraEditors.SimpleButton BtnRefresh;
        private DevExpress.XtraEditors.PictureEdit PicLicence1;
        private DevExpress.XtraEditors.PictureEdit PicLicence2;
        private DevExpress.XtraEditors.PictureEdit PicLicence3;
        private DevExpress.XtraEditors.SimpleButton BtnSearch;
        private DevExpress.XtraEditors.SimpleButton BtnRenew;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
    }
}