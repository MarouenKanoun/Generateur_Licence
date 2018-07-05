using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateurLicences.data.Cmd
{
    /// <summary>
    /// classe qui va contenir tout les requets sql pour les clients
    /// </summary>
    public static class CmdClient
    {
        #region .. Variable public..

        //public  string natureRequette;

        public enum CRUD
        {
            SELECT,
            UPDATE,
            DELETE,
            CREATE
        }
        #endregion

        #region .. Variable privé..
        #endregion

        #region .. Proprietée..
        #endregion

        #region .. Methode diverse de requet..

        /// <summary>
        /// requette permet d'extraire des elements(  ClientCode , ClientAdresse1, ClientAdresse2 , ClientCodePostale, ClientVille,  ClientPrenom)  de la table client 
        /// </summary>
        /// <returns> retourne un string qui presente la requet sql que on va passer a la methode convenable(suivant le type de la requet) qui attend se tring en parametre  </returns>
        public static string RequetteCaracteristiqueClient()
        {
            string cmd = "SELECT  ClientCode ,TypeLicences , ClientAdresse1, ClientAdresse2 , ClientCodePostal, ClientVille,  ClientPrenom  FROM dbo_Client";
            return cmd;
        }
        public static string RequetteClient()
        {
            string cmd = "SELECT  ClientPrenom  FROM dbo_Client";
            return cmd;
        }
        /// <summary>
        /// requet permet de chercher un nom d'administrateur et sont mot de passe dans la base de donné 
        /// </summary>
        /// <param name="NomAdmin"></param>
        /// <param name="CodeAdmin"></param>
        /// <returns></returns>
        public static string RequetteLogin(string NomAdmin, string CodeAdmin)
        {
            string cmd = "SELECT *   FROM dbo_Administrateur WHERE NomAdministrateur='" + NomAdmin + "' and CodeAdministrateur= '" + CodeAdmin + "'";
            return cmd;
        }
        /// <summary>
        /// Requet permet d'ajouter un Nouveau client Express ( un client expresse sert a ajouter des donner vitale pour la generation d'une Licence client ) 
        /// </summary>
        /// <param name="ClientCode"></param>
        /// <param name="NomClient"></param>
        /// <param name="Adresse1"></param>
        /// <param name="Adresse2"></param>
        /// <param name="CodePostale"></param>
        /// <param name="ville"></param>
        /// <returns></returns>
        public static string RequetAjoutClientRapide(string ClientCode, string NomClient, string Adresse1, string Adresse2, string CodePostale, string ville)
        {
            string cmd = "INSERT INTO dbo_Client (  ClientCode , ClientAdresse1, ClientAdresse2 , ClientCodePostal, ClientVille,  ClientPrenom ) VALUES ('" + ClientCode + "'," + "'" + NomClient + "'," + "'" + Adresse1 + "'," + "'" + Adresse2 + "'," + "'" + CodePostale + "'," + "'" + ville + "')";
            return cmd;
            // string cmd =""

        }
        public static string TypeClient(string NomClient  )
        {
            string cmd = "SELECT Type   from dbo_Administrateur where nomAdministrateur  ='" +NomClient+"'" ;
            return cmd;
            // string cmd =""

        }
        #endregion
    }
}