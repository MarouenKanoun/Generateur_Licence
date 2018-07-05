using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace GenerateurLicences
{
    /// <summary>
    /// Class permet de contenir tout les donné en rapport avec la base de donné 
    /// </summary>
    public class DataBaseManager
    {

        #region ..Proprietées..

        public bool IsConnected { get; } = true;
        public OleDbConnection Connexion { get; set; } = null;
        public OleDbTransaction CurrentTransaction { get; set; }
        public string Dbcnx { get; set; } = Consts.CheminConnect;

        #endregion

        #region ..CTOR..

        public DataBaseManager()
        {

        }

        #endregion

        #region..Methode publique..

        /// <summary>
        /// Methode permet d'ouvrir une connexion a la base de donné 
        /// </summary>
        /// <returns>retourne un bool qui indique l'etat de connection (true/connecté) ,(false/déconnecté)</returns>
        public bool OpenDBCnx()
        {
            /// try: permet d'essayer d'ouvrire une connexion si elle est pas ouverte 
            try
            {
                InstanceOleConnexion(Dbcnx);

                if (Connexion.State != ConnectionState.Open)
                {
                    Connexion.Open();
                }
                return IsConnected;
            }

            // si elle arrive pas elle va generer une exception 
            //TODO
            // creer une classe d'exception specifique 
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// // methode permet de fermer une connection 
        /// </summary>
        public bool CloseDbCnx()
        {
            try
            {
                InstanceOleConnexion(Dbcnx);
                if (Connexion.State != ConnectionState.Closed)
                {
                    Connexion.Close();
                }
                return !IsConnected;
            }
            catch
            {
                throw new Exception(Consts.MessageEchec);
            }
        }

        /// <summary>
        /// méthode  utilisée principalement pour des opérations de type UPDATE, INSERT, DELETE
        /// </summary>
        /// <param name="sqlCommand">Chaine SQL à exécuter</param>
        /// <returns>Nombre d'enregistrements traités</returns>
        public int ExecuteNonQuery(string sqlCommand)
        {
            try
            {
                int returnValue;
                OpenDBCnx();// on ouvre une connexion a la base de donné 
                OleDbCommand Command = Connexion.CreateCommand();// on crée une nouvelle commande 
                CurrentTransaction = Connexion.BeginTransaction();// 
                Command.Connection = Connexion;// on assoucie une commande a une connexion 
                Command.Transaction = CurrentTransaction;
                Command.CommandType = CommandType.Text;// on defenit le type de la commande a executer 
                Command.CommandText = sqlCommand;//chaine sql a executer 
                returnValue = Command.ExecuteNonQuery();// executer la requette 
                CurrentTransaction.Commit();
                return returnValue; //nombre d'enregistrements traités
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);// on genere un message d'echec en cas d'erreur 
            }
            finally
            {
                CloseDbCnx();// on ferme la connection 
            }
        }

        /// <summary>
        /// méthode utilisée principalement pour des opérations de type SELECT
        /// </summary>
        /// <param name="sqlCommand">Chaine SQL à exécuter</param>
        /// <returns>objReader c'est un objet de type reader  contenant les enregistrements</returns>
        public OleDbDataReader ExecuteReader(string sqlCommand)
        {
            try
            {
                OpenDBCnx();
                OleDbDataReader objReader = null;
                OleDbCommand objOleCommand = Connexion.CreateCommand();
                objOleCommand.Connection = Connexion;
                objOleCommand.CommandType = CommandType.Text;
                objOleCommand.CommandText = sqlCommand;
                objReader = objOleCommand.ExecuteReader();
                return objReader;
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                CloseDbCnx();
            }
        }

        /// <summary>
        /// methode permet d'instancier un object Connexion en passant le nom de  instance et le chemin de connexion deja mentionné dans les constante en parametre 
        /// </summary>
        /// <param name="chemin">chemin d'accé a  la base de donné (provider) et chaine de connetion </param>
        /// 
        public void InstanceOleConnexion(string cheminConnect)
        {
            Connexion = new OleDbConnection(cheminConnect);
        }

        #endregion
    }
}
