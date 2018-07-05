using DevExpress.XtraEditors;
using System;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;

namespace GenerateurLicences
{
    public static class DetailsRepository
    {

        #region ..Proprieté ..

        public static string FinLicence { get; set; }
        public static string DebutLicence { get; set; }
        public static string NumLicence { get; set; }
        public static string TypeLicence { get; set; }
        public static string NbreJourLicence { get; set; }
        public static string NomClient { get; set; }
        public static string PostCode { get; set; }

        #endregion

        /// <summary>
        /// Methode permet de décortique l'objet reader et d'affecter les resultat au edittext convenable 
        /// </summary>
        /// <param name="Objectrecup"></param>
        /// <param name="imputFinLicence"></param>
        /// <param name="imputDebutLicence"></param>
        /// <param name="imputNumLicnece"></param>
        /// <param name="imputTypeLicence"></param>
        /// <param name="imputJourRestant"></param>
        /// <param name="ImputNomClient"></param>
        /// <param name="_PostCode"></param>
        /// <param name="_JourRestant"></param>
        public static void DefractionnerObjetReaderDetails(OleDbDataReader Objectrecup, PictureEdit PicLice1, PictureEdit PicLice2, PictureEdit PicLice3, TextEdit imputFinLicence, TextEdit imputDebutLicence, RadioGroup GropLicences, TextEdit imputTypeLicence, TextEdit imputJourRestant, TextEdit ImputNomClient, TextEdit _PostCode, TextEdit _JourRestant)
        {
            while (Objectrecup.Read())
            {
                FinLicence = Objectrecup["DateFinLicence"].ToString();
                DebutLicence = Objectrecup["DateDebutLicence"].ToString();
                NumLicence = Objectrecup["NumLicence"].ToString();
                TypeLicence = Objectrecup["TypeLicences"].ToString();
                NbreJourLicence = Objectrecup["NbJoursLicence"].ToString();
                NomClient = Objectrecup["ClientPrenom"].ToString();
                PostCode = Objectrecup["ClientCodePostal"].ToString();
            }
            if (FinLicence.ToString() != string.Empty || FinLicence.ToString() != string.Empty)
            {
                DateTime newdateexpiration = Convert.ToDateTime(FinLicence);
                DateTime newdatedebut = Convert.ToDateTime(DebutLicence);
                TimeSpan ts = newdateexpiration - newdatedebut;
                int diff = ts.Days;
                imputJourRestant.Text = diff.ToString();
                imputFinLicence.Text = Convert.ToDateTime(FinLicence).ToString("dd-MM-yyyy");
                imputDebutLicence.Text = Convert.ToDateTime(DebutLicence).ToString("dd-MM-yyyy");
            }
            _JourRestant.Text = NbreJourLicence;
            if (TypeLicence.Trim() != string.Empty)
            {
                if (TypeLicence == "Licence1")
                {
                    GropLicences.SelectedIndex = GropLicences.Properties.Items.IndexOf(GropLicences.Properties.Items.Where(it => it.Description == TypeLicence).FirstOrDefault());
                    GropLicences.Properties.Appearance.BackColor = Color.Lime;
                    GropLicences.Properties.AppearanceDisabled.BackColor = Color.Lime;
                    PicLice1.BackColor = Color.Lime;
                    GropLicences.Properties.AppearanceFocused.BackColor = Color.Lime;
                    PicLice2.BackColor = Color.Lime;
                    GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Lime;
                    PicLice3.BackColor = Color.Lime;
                }
                else if (TypeLicence == "Licence2")
                {
                    GropLicences.SelectedIndex = GropLicences.Properties.Items.IndexOf(GropLicences.Properties.Items.Where(it => it.Description == TypeLicence).FirstOrDefault());
                    GropLicences.Properties.Appearance.BackColor = Color.Gold;
                    GropLicences.Properties.AppearanceDisabled.BackColor = Color.Gold;
                    PicLice1.BackColor = Color.Gold;
                    GropLicences.Properties.AppearanceFocused.BackColor = Color.Gold;
                    PicLice2.BackColor = Color.Gold;
                    GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Gold;
                    PicLice3.BackColor = Color.Gold;
                }
                else if (TypeLicence == "Licence3")
                {
                    GropLicences.SelectedIndex = GropLicences.Properties.Items.IndexOf(GropLicences.Properties.Items.Where(it => it.Description == TypeLicence).FirstOrDefault());
                    GropLicences.Properties.Appearance.BackColor = Color.Aqua;
                    GropLicences.Properties.AppearanceDisabled.BackColor = Color.Aqua;
                    PicLice1.BackColor = Color.Aqua;
                    GropLicences.Properties.AppearanceFocused.BackColor = Color.Aqua;
                    PicLice2.BackColor = Color.Aqua;
                    GropLicences.Properties.AppearanceReadOnly.BackColor = Color.Aqua;
                    PicLice3.BackColor = Color.Aqua;
                }
                else
                {
                    GropLicences.Properties.Appearance.BackColor = Color.White;
                    GropLicences.Properties.AppearanceDisabled.BackColor = Color.White;
                    GropLicences.Properties.AppearanceFocused.BackColor = Color.White;
                    GropLicences.Properties.AppearanceReadOnly.BackColor = Color.White;
                    PicLice1.BackColor = Color.White;
                    PicLice2.BackColor = Color.White;
                    PicLice3.BackColor = Color.White;
                }
            }
            else
            {
                GropLicences.Properties.Appearance.BackColor = Color.White;
                GropLicences.Properties.AppearanceDisabled.BackColor = Color.White;
                GropLicences.Properties.AppearanceFocused.BackColor = Color.White;
                GropLicences.Properties.AppearanceReadOnly.BackColor = Color.White;
                PicLice1.BackColor = Color.White;
                PicLice2.BackColor = Color.White;
                PicLice3.BackColor = Color.White;
            }


            imputTypeLicence.Text = NumLicence;
            ImputNomClient.Text = NomClient;
            _PostCode.Text = PostCode;
        }
        public static bool DefractionnerObjetReaderClient(OleDbDataReader Objectrecup, PictureEdit PicLice1, PictureEdit PicLice2, PictureEdit PicLice3, TextEdit NomClient, TextEdit CodePostale, TextEdit VilleClient, TextEdit Adresse1, TextEdit Adresse2, RadioGroup GropLicence)
        {
            while (Objectrecup.Read())
            {
                NomClient.Text = Objectrecup["ClientPrenom"].ToString();
                CodePostale.Text = Objectrecup["ClientCodePostal"].ToString();
                VilleClient.Text = Objectrecup["ClientVille"].ToString();
                Adresse1.Text = Objectrecup["ClientAdresse1"].ToString();
                Adresse2.Text = Objectrecup["ClientAdresse2"].ToString();

                if (Objectrecup["TypeLicences"].ToString().Trim() != string.Empty)
                {
                    GropLicence.SelectedIndex = GropLicence.Properties.Items.IndexOf(GropLicence.Properties.Items.Where(it => it.Description == Objectrecup["TypeLicences"].ToString()).FirstOrDefault());
                    if (GropLicence.Properties.Items[GropLicence.SelectedIndex].Description == "Licence1")
                    {
                        GropLicence.Properties.Appearance.BackColor = Color.Lime;
                        GropLicence.Properties.AppearanceDisabled.BackColor = Color.Lime;
                        PicLice1.BackColor = Color.Lime;
                        GropLicence.Properties.AppearanceFocused.BackColor = Color.Lime;
                        PicLice2.BackColor = Color.Lime;
                        GropLicence.Properties.AppearanceReadOnly.BackColor = Color.Lime;
                        PicLice3.BackColor = Color.Lime;
                    }
                    else if (GropLicence.Properties.Items[GropLicence.SelectedIndex].Description == "Licence2")
                    {
                        GropLicence.Properties.Appearance.BackColor = Color.Gold;
                        GropLicence.Properties.AppearanceDisabled.BackColor = Color.Gold;
                        PicLice1.BackColor = Color.Gold;
                        GropLicence.Properties.AppearanceFocused.BackColor = Color.Gold;
                        PicLice2.BackColor = Color.Gold;
                        GropLicence.Properties.AppearanceReadOnly.BackColor = Color.Gold;
                        PicLice3.BackColor = Color.Gold;
                    }
                    else if (GropLicence.Properties.Items[GropLicence.SelectedIndex].Description == "Licence3")
                    {
                        GropLicence.Properties.Appearance.BackColor = Color.Aqua;
                        GropLicence.Properties.AppearanceDisabled.BackColor = Color.Aqua;
                        PicLice1.BackColor = Color.Aqua;
                        GropLicence.Properties.AppearanceFocused.BackColor = Color.Aqua;
                        PicLice2.BackColor = Color.Aqua;
                        GropLicence.Properties.AppearanceReadOnly.BackColor = Color.Aqua;
                        PicLice3.BackColor = Color.Aqua;
                    }
                    return true;
                }
                else
                {
                    GropLicence.Properties.Appearance.BackColor = Color.White;
                    GropLicence.Properties.AppearanceDisabled.BackColor = Color.White;
                    GropLicence.Properties.AppearanceFocused.BackColor = Color.White;
                    GropLicence.Properties.AppearanceReadOnly.BackColor = Color.White;
                    PicLice1.BackColor = Color.White;
                    PicLice2.BackColor = Color.White;
                    PicLice3.BackColor = Color.White;
                }
                return false;
            }
            NomClient.Text = string.Empty;
            CodePostale.Text = string.Empty;
            VilleClient.Text = string.Empty;
            Adresse1.Text = string.Empty;
            Adresse2.Text = string.Empty;

            GropLicence.Properties.Appearance.BackColor = Color.White;
            GropLicence.Properties.AppearanceDisabled.BackColor = Color.White;
            GropLicence.Properties.AppearanceFocused.BackColor = Color.White;
            GropLicence.Properties.AppearanceReadOnly.BackColor = Color.White;
            PicLice1.BackColor = Color.White;
            PicLice2.BackColor = Color.White;
            PicLice3.BackColor = Color.White;

            return false;
        }
    }
}
