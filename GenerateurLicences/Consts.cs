using GenerateurLicences.Localisation;
using System;
using System.IO;
using System.Linq;

namespace GenerateurLicences
{

    /// <summary>
    /// classe va contenir tout les Constantes de la solution 
    /// </summary>
    public static class Consts
    {
        #region..variable public..

        /// <summary>
        /// Constante Provider qui permet l'accée a la base de donné 
        /// </summary>
        static string PathDataBase = Path.GetDirectoryName(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))).ToString() + "\\";
        public static string CheminConnect = (@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + PathDataBase + "DataBase.accdb");

        /// <summary>
        /// Constante contient  un message de retour negative sur la connection a la base de donné 
        /// </summary>
        public static string RetourKO = MessagesSystem.DataBaseConnectionFailed;

        /// <summary>
        /// Constante contennat un message d'echec 
        /// </summary>
        public const string MessageEchec = "operation failed";

        public static string CherercherNatureRequette = "Nature";

        public static string ChercherTextRequette = "Cmd";

        public static string EmptyString = MessagesSystem.StringEmpty;

        public static string Licence1 = "Licence1";
        public static string Licence2 = "Licence2";
        public static string Licence3 = "Licence3";
        public static string Licence4 = "Licence4";
        public static string Licence5 = "Licence5";
        public static string Licence6 = "Licence6";
        public static char Separation = '-';

        //public static string LicenceUserName = MessagesSystem.LicenceUserName;

        /// <summary>
        /// Type de commmande SQL à éffectuer
        /// </summary>
        public enum SqlCmdType
        {
            ExecuteReader,
            ExecuteScalar,
            ExecuteNonQuery
        }


        #endregion
    }
}