using DevExpress.XtraEditors;
using GenerateurLicences;
using GenerateurLicences.data.Cmd;
using GenerateurLicences.Localisation;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;

namespace GenerateurLicences 
{
    /// <summary>
    /// Class qui traite tout les operation en rapport avec le login 
    /// </summary>
    public static class LoginManager
    {
        /// <summary>
        /// Methode qui permet d'attribuer un code couleur a une textedit 
        /// </summary>
        /// <param name="ImputNameColor">Textedit qui va contenir le nom de l'administrateur </param>
        /// <param name="ImputPasswordColor">Textedit qui va contenir le mot de passe de l'utulisateur </param>
        /// <param name="CouleurNom">Couleur arribuer a la zone de saisie du nom </param>
        /// <param name="CouleurPassword">Couleur attribuer az la zone de saisie u mot de passe </param>
        public static void CodeCouleur(DevExpress.XtraEditors.TextEdit ImputNameColor, DevExpress.XtraEditors.TextEdit ImputPasswordColor, Color CouleurNom, Color CouleurPassword)
        {
            ImputNameColor.BackColor = CouleurNom;
            ImputPasswordColor.BackColor = CouleurPassword;
        }

        /// <summary>
        /// Methode qui permet de faire une tetative de connection a la base de donné 
        /// </summary>
        /// <param name="ImputNom">Text saisie dans la zone de text du nom de l'administrateur</param>
        /// <param name="ImputPassword">Zone de saisie du mot de passe </param>
        /// <returns>true si les identitifant sont correcte , false si non </returns>
        public static bool LoginEssai(string ImputNom, string ImputPassword, XtraForm frm)
        {
            OleDbDataReader MONoBJET = ProgramManager.Chargementreader(CmdClient.RequetteLogin(ImputNom, ImputPassword));
            int count = 0;
            bool LoginSucc;
            while (MONoBJET.Read())
            {
                count += 1;
            }
            if (count == 1)
            {
                LoginManager.LoginProcess(true);
                LoginSucc = true;
            }
            else
            {
                LoginManager.LoginProcess(false);
                LoginSucc = false;
            }
            return LoginSucc;

        }

        /// <summary>
        /// methode permet d'aller d'une fenetre a la fenetre suivante si le login se passe Bien 
        /// </summary>
        public static bool LoginProcess(bool result)
        {
            _LoginProcess = result;
            return result;
        }
        public static bool _LoginProcess { get; set; }
        /// <summary>
        /// Methode permet de detecter les erreur sur le formlaire
        /// </summary>
        /// <param name="ImputNom">Nom de l'administrateur </param>
        /// <param name="ImputPassword">Password de l'administrateur </param>
        /// <returns></returns>
        public static string DetecteurErreur(string ImputNom, string ImputPassword, DevExpress.XtraEditors.TextEdit ImputNameColor, DevExpress.XtraEditors.TextEdit ImputPasswordColor)
        {
            string Erreur;
            ImputNameColor.Text = ""; ImputPasswordColor.Text = "";
            if (ImputNom == string.Empty && ImputPassword == string.Empty)
            {
                Erreur = MessagesSystem.FormulaireEmpty;
                CodeCouleur(ImputNameColor, ImputPasswordColor, Color.Red, Color.Red);
            }
            else if (ImputNom == string.Empty)
            {
                Erreur = MessagesSystem.NomEmpty;
                CodeCouleur(ImputNameColor, ImputPasswordColor, Color.OrangeRed, Color.White);
            }
            else if (ImputPassword == string.Empty)
            {
                Erreur = MessagesSystem.PasswordEmpty;
                CodeCouleur(ImputNameColor, ImputPasswordColor, Color.White, Color.OrangeRed);
            }
            else
            {
                Erreur = MessagesSystem.IdentifiantInvalide;
                CodeCouleur(ImputNameColor, ImputPasswordColor, Color.Red, Color.Red);
            }
            return Erreur;
        }
    }
}

