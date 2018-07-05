using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using GenerateurLicences.data.Cmd;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;

namespace GenerateurLicences
{
    /// <summary>
    /// Classe permet de regroper tout les classe et communique avec les interfaces 
    /// </summary>
    public static class ProgramManager
    {
        /// <summary>
        /// Methode permet de charger un object reader 
        /// </summary>
        /// <param name="requette"></param>
        /// <returns></returns>
        public static OleDbDataReader Chargementreader(string requette)
        {
            DataBaseManager datamanager = new DataBaseManager();
            OleDbDataReader Objetrecuperer = datamanager.ExecuteReader(requette);
            return Objetrecuperer;
        }

        /// <summary>
        ///  //methode qui permet de transformer l'objet reader recuperer de la requet en liste de donné
        /// </summary>
        /// <param name="ObjetReader"></param>
        /// <returns></returns>
        public static List<Client> Chargement(OleDbDataReader ObjetReader)
        {
            ClientRepository repclient = new ClientRepository();
            List<Client> element = repclient.CastReaderResult(ObjetReader);
            return element;
        }

        /// <summary>
        ///   // methode permet a l'option coché dans le combobox de safficher dans le textedit 
        /// </summary>
        /// <param name="NomRadioButton"></param>
        /// <param name="Options"></param>
        //public static void SyncronisationRadioOption(CheckEdit NomRadioButton, TextEdit Options)
        //{
        //    Options.Text = (NomRadioButton.Checked) ? NomRadioButton.Text : string.Empty;
        //}

        /// <summary>
        ///    methode permet a l'option coché dans le combobox de safficher dans le textedit     /// </summary>
        /// <param name="DestinationData"></param>
        /// <param name="SourceRecuperation"></param>
        /// <param name="ElementRecuperer"></param>
        public static void RecupererElementRow(TextEdit DestinationData, DevExpress.XtraGrid.Views.Grid.GridView SourceRecuperation, string ElementRecuperer)
        {
            DestinationData.Text = SourceRecuperation.GetFocusedRowCellValue(ElementRecuperer).ToString();
        }
        public static bool RecupererElementRow(RadioGroup radioGroup, PictureEdit PicLice1, PictureEdit PicLice2, PictureEdit PicLice3, DevExpress.XtraGrid.Views.Grid.GridView SourceRecuperation, string ElementRecuperer)
        {
            if (SourceRecuperation.GetFocusedRowCellValue(ElementRecuperer).ToString().Trim() != string.Empty)
            { string Licenc = SourceRecuperation.GetFocusedRowCellValue(ElementRecuperer).ToString();
                if (Licenc == "Licence1")
                {
                    radioGroup.SelectedIndex = radioGroup.Properties.Items.IndexOf(radioGroup.Properties.Items.Where(it => it.Description == Licenc).FirstOrDefault());
                    radioGroup.Properties.Appearance.BackColor = Color.Lime;
                    radioGroup.Properties.AppearanceDisabled.BackColor = Color.Lime;
                    radioGroup.Properties.AppearanceFocused.BackColor = Color.Lime;
                    radioGroup.Properties.AppearanceReadOnly.BackColor = Color.Lime;
                    PicLice1.BackColor = Color.Lime;
                    PicLice2.BackColor = Color.Lime;
                    PicLice3.BackColor = Color.Lime;
                }
                else if (Licenc == "Licence2")
                {
                    radioGroup.SelectedIndex = radioGroup.Properties.Items.IndexOf(radioGroup.Properties.Items.Where(it => it.Description == Licenc).FirstOrDefault());
                    radioGroup.Properties.Appearance.BackColor = Color.Gold;
                    radioGroup.Properties.AppearanceDisabled.BackColor = Color.Gold;
                    radioGroup.Properties.AppearanceFocused.BackColor = Color.Gold;
                    radioGroup.Properties.AppearanceReadOnly.BackColor = Color.Gold;
                    PicLice1.BackColor = Color.Gold;
                    PicLice2.BackColor = Color.Gold;
                    PicLice3.BackColor = Color.Gold;

                }
                else if (Licenc == "Licence3")
                {
                    radioGroup.SelectedIndex = radioGroup.Properties.Items.IndexOf(radioGroup.Properties.Items.Where(it => it.Description == Licenc).FirstOrDefault());
                    radioGroup.Properties.Appearance.BackColor = Color.Aqua;
                    radioGroup.Properties.AppearanceDisabled.BackColor = Color.Aqua;
                    radioGroup.Properties.AppearanceFocused.BackColor = Color.Aqua;
                    radioGroup.Properties.AppearanceReadOnly.BackColor = Color.Aqua;
                    PicLice1.BackColor = Color.Aqua;
                    PicLice2.BackColor = Color.Aqua;
                    PicLice3.BackColor = Color.Aqua;
                }
                else
                {
                    radioGroup.SelectedIndex = 0;
                    radioGroup.Properties.Appearance.BackColor = Color.White;
                    radioGroup.Properties.AppearanceDisabled.BackColor = Color.White;
                    radioGroup.Properties.AppearanceFocused.BackColor = Color.White;
                    radioGroup.Properties.AppearanceReadOnly.BackColor = Color.White;
                    PicLice1.BackColor = Color.White;
                    PicLice2.BackColor = Color.White;
                    PicLice3.BackColor = Color.White;
                    return false;
                }
                return true;
            }
            else
            {
                radioGroup.SelectedIndex = 0;
                radioGroup.Properties.Appearance.BackColor = Color.White;
                radioGroup.Properties.AppearanceDisabled.BackColor = Color.White;
                radioGroup.Properties.AppearanceFocused.BackColor = Color.White;
                radioGroup.Properties.AppearanceReadOnly.BackColor = Color.White;
                PicLice1.BackColor = Color.White;
                PicLice2.BackColor = Color.White;
                PicLice3.BackColor = Color.White;
                return false;
            }
        }

        /// <summary>
        ///  methode permet d'ajouter des element dans la base de donné 
        /// </summary>
        /// <param name="requette"></param>
        public static void InserstionData(string requette)
        {
            DataBaseManager datamanager = new DataBaseManager();
            datamanager.ExecuteNonQuery(requette);
        }

        /// <summary>
        /// methode permet d'executer la requet de la vue detail client 
        /// </summary>
        /// <param name="CodeClientDetails"></param>
        /// <returns></returns>
        public static OleDbDataReader RecupDataDetails(string CodeClientDetails)
        {
            OleDbDataReader Result = null;
            DataBaseManager datamanager = new DataBaseManager();
            Result = datamanager.ExecuteReader(CmdLicenceLoad.LoadDataDetails(CodeClientDetails));
            return Result;
        }
        public static OleDbDataReader RecupDataClient(string CodeClientDetails)
        {
            OleDbDataReader Result = null;
            DataBaseManager datamanager = new DataBaseManager();
            Result = datamanager.ExecuteReader(CmdLicenceLoad.LoadDataClient(CodeClientDetails));
            return Result;
        }

        /// <summary>
        /// methode permet d'ajouter un client avec un minimum de parametre requise pour la geneneration d'une nouvelle licence 
        /// </summary>
        /// <param name="requetinsert"></param>
        public static void InsertClientRapide(string requetinsert)
        {
            DataBaseManager Basemanager = new DataBaseManager();
            Basemanager.ExecuteNonQuery(requetinsert);
        }

        /// <summary>
        /// Methode qui permet de griser des composant inutiles pour l'operation de chercher les details client avec le code client 
        /// </summary>
        /// <param name="ImputNom"></param>
        /// <param name="Ville"></param>
        /// <param name="Check"></param>
        /// <param name="buttonDetails"></param>
        /// 
        public static void DetailsLicence(GridControl GcLicence , PictureEdit PicLicence1, PictureEdit PicLicence2, PictureEdit PicLicence3, TextEdit NomClient, TextEdit CodeClient, TextEdit CodePostale, TextEdit VilleClient, TextEdit Adresse1,
            TextEdit Adresse2, RadioGroup GropLicences, SimpleButton GenererLicence, TextEdit ImputLicences, TextEdit DateDebutLicenece,
            TextEdit DateFin, TextEdit NombreDeJour, SimpleButton Sauvgarder, SimpleButton BoutonDetails, SimpleButton ButtonAjout)
        {
            GcLicence.Enabled = true;
            PicLicence1.Enabled = false;
            PicLicence2.Enabled = false;
            PicLicence3.Enabled = false;
            NomClient.Enabled = false; NomClient.ResetText();
            CodeClient.Enabled = true; CodeClient.ResetText();
            CodePostale.Enabled = false; CodePostale.ResetText();
            VilleClient.Enabled = false; VilleClient.ResetText();
            Adresse1.Enabled = false; Adresse1.ResetText();
            Adresse2.Enabled = false; Adresse2.ResetText();
            GropLicences.Enabled = false;
            GenererLicence.Enabled = false;
            ImputLicences.ResetText();
            DateDebutLicenece.ResetText();
            DateFin.ResetText();
            NombreDeJour.ResetText();

            Sauvgarder.Enabled = false;
            BoutonDetails.Enabled = true;
            ButtonAjout.Enabled = false;

        }
        public static void SetModeNormale(GridControl GcLicence,PictureEdit PicLicence1, PictureEdit PicLicence2, PictureEdit PicLicence3, TextEdit NomClient, TextEdit CodeClient, TextEdit CodePostale, TextEdit VilleClient, TextEdit Adresse1,
            TextEdit Adresse2, RadioGroup GropLicences, SimpleButton GenererLicence, TextEdit ImputLicences, TextEdit DateDebutLicenece, 
            TextEdit DateFin, TextEdit NombreDeJour, SimpleButton Sauvgarder, SimpleButton BoutonDetails, SimpleButton ButtonAjout)
        {
            GcLicence.Enabled = true;
            PicLicence1.Enabled = true;
            PicLicence2.Enabled = true;
            PicLicence3.Enabled = true;
            NomClient.Enabled = true; NomClient.ResetText();
            CodeClient.Enabled = true; CodeClient.ResetText();
            CodePostale.Enabled = true; CodePostale.ResetText();
            VilleClient.Enabled = true; VilleClient.ResetText();
            Adresse1.Enabled = true; Adresse1.ResetText();
            Adresse2.Enabled = true; Adresse2.ResetText();
            GropLicences.Enabled = true;
            GenererLicence.Enabled = true;
            ImputLicences.ResetText();
            DateDebutLicenece.ResetText();
            DateFin.ResetText();
            NombreDeJour.ResetText();

            Sauvgarder.Enabled = true;
            BoutonDetails.Enabled = false;
            ButtonAjout.Enabled = false;
        }

        /// <summary>
        /// Methode qui permet de griser des composant inutiles pour l'operation de ajouter  client express avec le code client 
        /// </summary>
        /// <param name="ImputNom"></param>
        /// <param name="Ville"></param>
        /// <param name="Check"></param>
        /// <param name="buttonDetails"></param>
        public static void AjoutExppress(GridControl GcLicence, PictureEdit PicLicence1, PictureEdit PicLicence2, PictureEdit PicLicence3, TextEdit NomClient, TextEdit CodeClient, TextEdit CodePostale, TextEdit VilleClient, TextEdit Adresse1,
            TextEdit Adresse2, RadioGroup GropLicences, SimpleButton GenererLicence, TextEdit ImputLicences, TextEdit DateDebutLicenece,
            TextEdit DateFin, TextEdit NombreDeJour, SimpleButton Sauvgarder, SimpleButton BoutonDetails, SimpleButton ButtonAjout)
        {
            GcLicence.Enabled = false;
            PicLicence1.Enabled = false;
            PicLicence2.Enabled = false;
            PicLicence3.Enabled = false;
            NomClient.Enabled = true; NomClient.ResetText();
            CodeClient.Enabled = true; CodeClient.ResetText();
            CodePostale.Enabled = true; CodePostale.ResetText();
            VilleClient.Enabled = true; VilleClient.ResetText();
            Adresse1.Enabled = true; Adresse1.ResetText();
            Adresse2.Enabled = true; Adresse2.ResetText();
            GropLicences.Enabled = false;
            GenererLicence.Enabled = false;
            ImputLicences.ResetText();
            DateDebutLicenece.ResetText();
            DateFin.ResetText();
            NombreDeJour.ResetText();

            Sauvgarder.Enabled = false;
            BoutonDetails.Enabled = false;
            ButtonAjout.Enabled = true;

        }

        /// <summary>
        /// methode permer de basculer vers le mode generer licence , cette methode permet d'activer et de déactiver les bonne elment pour le m=fonctionnement de ce mode 
        /// </summary>
        /// <param name="Check"></param>
        /// <param name="ButtonAjout"></param>
        /// <param name="ImputNom"></param>
        /// <param name="CodePostale"></param>
        /// <param name="Adresse1"></param>
        /// <param name="Adresse2"></param>
        /// <param name="CodeClient"></param>
        /// <param name="Ville"></param>
        /// <param name="buttonGerer"></param>
        /// <param name="ButtonSauver"></param>
        /// 

        /// <summary>
        /// methode permet d'atribuer un couleur a un textedit 
        /// </summary>
        /// <param name="imputCodeColor"></param>
        /// <param name="ImputZipColor"></param>
        /// <param name="Couleurzip"></param>
        /// <param name="CouleurCode"></param>
        public static void CodeCouleurClientExpress(TextEdit imputCodeColor, Color CouleurCode)
        {
            imputCodeColor.BackColor = CouleurCode;
        }

        /// <summary>
        /// methode permet de detecter les erreur sur le formulaire de saise d'un nouveau client 
        /// </summary>
        public static bool DetecteurErreurSaisieNewClient(TextEdit NomClient, TextEdit CodeClient, TextEdit CodePostale, TextEdit Adresse1)
        {
            if (CodeClient.Text == string.Empty)
            {
                CodeCouleurClientExpress(CodeClient, Color.Red);
                CodeClient.Select();
                return false;
            }
            else if(NomClient.Text == string.Empty)
            {
                CodeCouleurClientExpress(NomClient, Color.Red);
                NomClient.Select();
                return false;
            }
            else if (CodePostale.Text == string.Empty)
            {
                CodeCouleurClientExpress(CodePostale, Color.Red);
                CodePostale.Select();
                return false;
            }
            else if (Adresse1.Text == string.Empty)
            {
                CodeCouleurClientExpress(Adresse1, Color.Red);
                Adresse1.Select();
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}