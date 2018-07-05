using DevExpress.XtraEditors;
using GenerateurLicences.Localisation;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateurLicences
{
    /// <summary>
    /// Classe permet de traiter 
    /// </summary>
    public static class LicenceDelaisManager
    {
        /// <summary>
        /// methode qui determine la durer de la licence
        /// </summary>
        /// <param name="Option"> l'option selectionné par l'utulisateur pour defenir le type de la licnece </param>
        /// <param name="LongeurLicnece">Durer de licence </param>
        public static int LicenceLength(string Option)
        {
            int LongeurLicnece = 0;
            if (Option == "Licence1")
            {
                LongeurLicnece = 30;
            }
            else if (Option == "Licence2")
            {
                LongeurLicnece = 90;
            }
            else if (Option == "Licence3")
            {
                LongeurLicnece = 360;
            }

            return LongeurLicnece;
        }

        /// <summary>
        /// methode permet de determiner la fin de licence 
        /// </summary>
        public static string FinLicence(DateTime DateDebut, int DurerLicnece)
        {
            DateTime DateFinLicence = DateDebut.AddDays(DurerLicnece);
            return DateFinLicence.ToString();
        }

        /// <summary>
        /// METHODE PERMET d'attribuer une couleur a la textbox
        /// </summary>
        /// <param name="JourRestant"></param>
        /// <param name="Couleur"></param>
        public static void ReactionCouleur(DevExpress.XtraEditors.TextEdit JourRestant, Color Couleur)
        {
            JourRestant.BackColor = Couleur;
        }

        /// <summary>
        /// methode permet de retourner une reponse 
        /// </summary>
        /// <param name="Reponse"></param>
        /// <returns></returns>
        public static string Reponse(string Reponse)
        {
            return Reponse;
        }

        /// <summary>
        /// METHODE   permet de affecter une couleur   a l'edit text correpondante nombre de jour restant 
        /// </summary>
        /// <param name="JourRestant"></param>
        /// <returns></returns>
        public static string CodeCouleurDetails(DevExpress.XtraEditors.TextEdit JourRestant)
        {
            if (JourRestant.Text!="")
            {
                int NbJourRestant = Convert.ToInt32(JourRestant.Text);
                string EvaluationContrat = MessagesSystem.StringEmpty;
                if (NbJourRestant <= 0)
                {
                    ReactionCouleur(JourRestant, Color.Red);
                    EvaluationContrat = MessagesSystem.ReponseRouge + NbJourRestant + MessagesSystem.Jours;
                }
                else if (NbJourRestant > 0 && NbJourRestant <= 11)
                {
                    ReactionCouleur(JourRestant, Color.Orange);
                    EvaluationContrat = MessagesSystem.ReponseOrange + NbJourRestant + MessagesSystem.Jours;
                }
                else
                {
                    ReactionCouleur(JourRestant, Color.GreenYellow);
                    EvaluationContrat = MessagesSystem.RepnseVert + NbJourRestant + MessagesSystem.Jours;
                }
                return EvaluationContrat;
            }
            return "";
        }

        /// <summary>
        /// methode permet de relancer un calcule pour dedefinir le nombre de jour de licence si l'utulisateur change les date de debut et la date de fin de la licence 
        /// </summary>
        public static int Recalcule(IWin32Window owner, DevExpress.XtraEditors.DateEdit ImputDateDebut, DevExpress.XtraEditors.DateEdit ImputDateDeFin, DevExpress.XtraEditors.TextEdit ImputNombreDeJour)
        {
            int diff = 0;
            try
            {
                DateTime NewDateDebut = Convert.ToDateTime(ImputDateDebut.Text);
                DateTime NewDateDin = Convert.ToDateTime(ImputDateDeFin.Text);
                TimeSpan DiffJours = NewDateDin - NewDateDebut;
                diff = DiffJours.Days;
                ImputNombreDeJour.Text = diff.ToString();

            }
            catch
            {

                MsgBox.Show(owner, MessagesSystem.ErreurSaisieDate);
            }
            return diff;
        }
        public static void Recalcule(IWin32Window owner,RadioGroup GropLicences, DevExpress.XtraEditors.DateEdit ImputDateDebut, DevExpress.XtraEditors.DateEdit ImputDateDeFin, DevExpress.XtraEditors.TextEdit ImputNombreDeJour)
        {
            try
            {
                ImputDateDeFin.Text = Convert.ToDateTime(ImputDateDebut.Text).AddDays(Convert.ToDouble(GropLicences.Properties.Items[GropLicences.SelectedIndex].Tag)).ToString("dd-MM-yyyy");
                ImputNombreDeJour.Text = GropLicences.Properties.Items[GropLicences.SelectedIndex].Tag.ToString();
            }
            catch
            {
                MsgBox.Show(owner, MessagesSystem.ErreurSaisieDate);
            }
        }
    }
}

