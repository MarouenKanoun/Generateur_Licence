using DevExpress.Utils.MVVM;
using DevExpress.XtraBars.Docking2010.Views.WindowsUI;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenerateurLicences
{
    public partial class FrmOwner : RibbonForm
    {
        public FrmOwner()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            var screen = Screen.PrimaryScreen.WorkingArea;
            Height = screen.Height;
            Width = screen.Width;
        }

        private void BtnAcceuil_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmAcceuil();
            var ISACTIVE = false;
            foreach (XtraForm Child in MdiChildren)
                if (Child.Name == frm.Name)
                {
                    Child.Activate();
                    ISACTIVE = true;
                    break;
                }
            if (!ISACTIVE)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void BtnDetails_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new FrmDetails();
            var ISACTIVE = false;
            foreach (XtraForm Child in MdiChildren)
                if (Child.Name == frm.Name)
                {
                    Child.Activate();
                    ISACTIVE = true;
                    break;
                }
            if (!ISACTIVE)
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }
    }
}
