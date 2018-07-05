using DevExpress.XtraEditors;
using GenerateurLicences;
using GenerateurLicences.Localisation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenerateurLicences
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (LoginManager.LoginEssai(textEdit1.Text, textEdit2.Text, this) == true)
                {
                    LoginManager.CodeCouleur(textEdit1, textEdit2, Color.GreenYellow, Color.GreenYellow);
                    this.Close();
                }
                else
                {
                    MsgBox.Show(this, LoginManager.DetecteurErreur(textEdit1.Text, textEdit2.Text, textEdit1, textEdit2));
                }
            }
            catch 
            {
                MsgBox.Show(this, MessagesSystem.ErreurInconnue);
            }
        }

        private void LoginTextChanged(object sender, EventArgs e)
        {
            if ((sender as TextEdit).Text.Trim().Length==1)
            {
                (sender as TextEdit).BackColor = Color.White;
            }
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }
    }
}
