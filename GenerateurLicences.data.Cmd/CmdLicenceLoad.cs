using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateurLicences.data.Cmd
{
    public static class CmdLicenceLoad
    {

        /// <summary>
        /// methode permet de inserer des donner de licence dans la base de donné 
        /// </summary>
        /// <param name="imputBeginDate"> date debut Licence </param>
        /// <param name="imputLimitDate">Date fin licence </param>
        /// <param name="imputLicenceSerial">Numero de licence </param>
        /// <param name="imputdelayDays"></param>
        /// <param name="imputCodeclient"></param>
        /// <param name="imputTypeLicence"></param>
        /// <returns></returns>
        public static string LoadDataToDataBase(string imputBeginDate, string imputLimitDate, string imputLicenceSerial, string imputdelayDays, string imputCodeclient, string imputTypeLicence)
        {
            string cmd = "UPDATE dbo_Client SET DateDebutLicence ='" + imputBeginDate + "'," + "DateFinLicence ='" + imputLimitDate + "'," + "NumLicence='" + imputLicenceSerial + "'," + "NbJoursLicence='" + imputdelayDays + "'," + "TypeLicences='" + imputTypeLicence + "'" + "WHERE ClientCode ='" + imputCodeclient + "'";
            return cmd;
        }
        public static string UpdateDataClient(TextEdit NomClient, TextEdit CodeClient, TextEdit CodePostale, TextEdit VilleClient,
            TextEdit Adresse1, TextEdit Adresse2,RadioGroup GropLicences)
        {
            string cmd = "UPDATE dbo_Client SET ClientCodePostal ='" + CodePostale.Text + "', ClientVille ='" + VilleClient.Text + "'," +
                "ClientAdresse1='" + Adresse1.Text + "'," + "ClientAdresse2='" + Adresse1.Text + "'," +
                "TypeLicences='" + GropLicences.Properties.Items[GropLicences.SelectedIndex].Description + "',ClientPrenom ='" + NomClient.Text + "'" + "WHERE ClientCode ='" + CodeClient.Text + "'";
            return cmd;
        }
        /// <summary>
        /// METHODE permet de lancer une requet pour chercher lescaracteristique de licence client 
        /// </summary>
        /// <param name="CodeClient"></param>
        /// <returns></returns>
        public static string LoadDataDetails(string CodeClient)
        {
            string cmd = "SELECT  DateDebutLicence , DateFinLicence , NbJoursLicence , ClientPrenom, NumLicence,TypeLicences,ClientCodePostal FROM dbo_Client WHERE ClientCode='" + CodeClient + "'";
            return cmd;
        }
        public static string LoadDataClient(string CodeClient)
        {
            string cmd = "SELECT  ClientPrenom,ClientCodePostal,ClientVille,ClientAdresse1, ClientAdresse2 ,TypeLicences    FROM dbo_Client WHERE ClientCode='" + CodeClient + "'";
            return cmd;
        }
    }
    /// <summary>
    /// Methode permet d'enregistrer les details dans la base de donné au case ou on a modifier des donnée de licence au case d'erreur ou par un choix de l'administrateur 
    /// </summary>
    /// <returns></returns>
    //        public static string SaveChangementDetails()
    //        {
    //            string cmd ="UPDATE dbo_Client"
    ////                UPDATE dbo_Client
    ////SET  DateDebutLicence =  '07/04/1992',
    ////   DateFinLicence= '07/08/2017',
    ////  NbJoursLicence = '32',
    ////ClientPrenom='moi',
    ////NumLicence='123',
    ////TypeLicences ='Licence1'
    ////where ClientCode='ABO02';
    //        }


}