using DevExpress.XtraEditors;
using System;
using System.Linq;

namespace GenerateurLicences
{
    public static class GetLicences
    {
        /// <summary>
        /// classe permet de former un numero de serie client a partir des donnée client 
        /// </summary>

        #region .. Variable public..
        #endregion

        #region .. Variable privé..
        public enum TypeLicence
        {
            Option1,
            Option2,
            Option3,
            Option4,
            Option5,
            option6
        }
        /// <summary>
        /// methode permet de creer une logique de creation de licence 
        /// </summary>
        /// <param name="element1">Nom Utulisateur </param>
        /// <param name="element2">Code Client </param>
        /// <param name="element3">Code Postale Client </param>
        /// <param name="element4">Adresse 1</param>
        /// <param name="element5">Adresse 2</param>
        /// <param name="element6">Ville</param>
        /// <param name="Option">Option de licence (Licence1 , Licence 2 , Licence 3) </param>
        /// <returns></returns>
        public static string GetSeriale(TextEdit NomClient, TextEdit CodeClient, TextEdit CodePostale, TextEdit Adresse1, RadioGroup GropLicences)
        {

            string LicenceUser;

            switch (GropLicences.Properties.Items[GropLicences.SelectedIndex].Description)
            {
                case "Licence1":
                    LicenceUser = GropLicences.Properties.Items[GropLicences.SelectedIndex].Tag + "Day"+ Consts.Separation + 
                        (NomClient.Text + Consts.Separation + CodeClient.Text + Consts.Separation + CodePostale.Text + 
                        Consts.Separation + Adresse1.Text).Replace("--", "-");
                    break;
                case "Licence2":
                    LicenceUser = GropLicences.Properties.Items[GropLicences.SelectedIndex].Tag + "DAY" + Consts.Separation +
                        (NomClient.Text + Consts.Separation + CodeClient.Text + Consts.Separation + CodePostale.Text +
                        Consts.Separation + Adresse1.Text).Replace("--", "-");
                    break;
                case "Licence3":
                    LicenceUser = GropLicences.Properties.Items[GropLicences.SelectedIndex].Tag + "DAY" + Consts.Separation +
                        (NomClient.Text + Consts.Separation + CodeClient.Text + Consts.Separation + CodePostale.Text +
                        Consts.Separation + Adresse1.Text).Replace("--", "-");
                    break;
                default:
                    LicenceUser = Consts.EmptyString;
                    break;
            }
            return LicenceUser;
        }
        public static string GetSeriale(TextEdit NomClient, TextEdit CodeClient, TextEdit CodePostale, RadioGroup GropLicences)
        {

            string LicenceUser;

            switch (GropLicences.Properties.Items[GropLicences.SelectedIndex].Description)
            {
                case "Licence1":
                    LicenceUser = GropLicences.Properties.Items[GropLicences.SelectedIndex].Tag + "Day" + Consts.Separation +
                        (NomClient.Text + Consts.Separation + CodeClient.Text + Consts.Separation + CodePostale.Text).Replace("--", "-");
                    break;
                case "Licence2":
                    LicenceUser = GropLicences.Properties.Items[GropLicences.SelectedIndex].Tag + "DAY" + Consts.Separation +
                        (NomClient.Text + Consts.Separation + CodeClient.Text + Consts.Separation + CodePostale.Text ).Replace("--", "-");
                    break;
                case "Licence3":
                    LicenceUser = GropLicences.Properties.Items[GropLicences.SelectedIndex].Tag + "DAY" + Consts.Separation +
                        (NomClient.Text + Consts.Separation + CodeClient.Text + Consts.Separation + CodePostale.Text ).Replace("--", "-");
                    break;
                default:
                    LicenceUser = Consts.EmptyString;
                    break;
            }
            return LicenceUser;
        }
        #endregion

    }
}