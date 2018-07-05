using System;
using System.Linq;
using System.Windows.Forms;

namespace GenerateurLicences
{
    public partial class MsgBox : DevExpress.XtraEditors.XtraForm
    {
        public static MsgBox msgbox;
        public static DialogResult result = DialogResult.No;
        public MsgBox()
        {
            InitializeComponent();
        }
        public static DialogResult Show(IWin32Window owner, string msgtext)
        {
            msgbox = new MsgBox
            {
                Width = (owner as Form).Width - 15,
                Text = "Waring"
            };
            msgbox.labelControl1.Text = msgtext;
            msgbox.ShowDialog();
            return result;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            Close();
        }

        private void MsgBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                result = DialogResult.No;
                Close();
            }
        }
    }
}