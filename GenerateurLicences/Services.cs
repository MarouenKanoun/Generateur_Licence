using System;
using System.Linq;

namespace GenerateurLicences
{
    class Services
    {
        #region..Variable Public..



        DataBaseManager BaseManager = new DataBaseManager();

        /// <summary>
        /// type de commande sql a executer 
        /// </summary>
        public enum TypeCommande
        {
            ExecuteReader,
            // ExecuteScalar,
            ExecuteNonQuery
        }

        /// <summary>
        /// classe concerné par le service
        /// </summary>
        public enum ObjClass
        {
            Client,
            Fournisseur
        }
        public enum ExecuteResult
        {
            ObjReader,
            Value
        }

        #endregion

        #region..CTOR..

        public Services()
        {

        }

        #endregion

        #region..Methodes Diverses..

        /// <summary>
        /// methode permet de se connecter a la base de donner 
        /// </summary>
        public void SeConnecter()
        {

        }
        /// <summary>
        /// methode permet d'executer les commande 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="Entitee"></param>
        /// <param name="CommandeSql"></param>
        /// <returns></returns>
        public void ExecuterCommande(TypeCommande type, ObjClass Entitee, string CommandeSql)
        {
            switch (type)
            {
                case TypeCommande.ExecuteReader:

                    break;

                //case TypeCommande.ExecuteScalar:
                // break;

                case TypeCommande.ExecuteNonQuery:

                    break;

                default:
                    break;
            }

            switch (Entitee)
            {
                case ObjClass.Client:
                    break;
                case ObjClass.Fournisseur:
                    break;
                default:
                    break;
            }
        }

        public void FormaterElementClient()
        {

        }

        #endregion
    }
}