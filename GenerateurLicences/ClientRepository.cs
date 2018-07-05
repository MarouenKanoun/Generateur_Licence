using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateurLicences
{
    /// <summary>
    /// Class permet qui cast un reader en liste de client 
    /// </summary>
    class ClientRepository
    {
        #region..CTOR..
        public ClientRepository()
        {

        }
        #endregion

        #region..Methode Diverse..
        /// <summary>
        /// Méthode qui cast le résultat d'un Reader en object de type CLIENT( avec seulment quelque parametre de client) 
        /// </summary>
        /// <param name="result"></param>
        public List<Client> CastReaderResult(OleDbDataReader reader)
        {
            List<Client> resultList = new List<Client>();
            Client current = null;

            while (reader.Read())
            {
                current = new Client();
                current.ClientCode = reader.IsDBNull(0) ? string.Empty : reader.GetString(0);
                current.TypeLicences = reader.IsDBNull(1) ? string.Empty : reader.GetString(1);
                current.ClientAdresse1 = reader.IsDBNull(2) ? string.Empty : reader.GetString(2);
                current.ClientAdresse2 = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                current.ClientCodePostal = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                current.ClientVille = reader.IsDBNull(5) ? string.Empty : reader.GetString(5);
                current.ClientPrenom = reader.IsDBNull(6) ? string.Empty : reader.GetString(6);

                resultList.Add(current);
            }
            return resultList;
        }
        #endregion
    }
}
