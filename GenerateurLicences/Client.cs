using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateurLicences
{       
    /// <summary>
    /// Classe permet de crer un client 
    /// </summary>
    public class Client
    {
        #region..Variable Privée..

        string clientCode;
        string clientPrenom;
        string clientAdresse1;
        string clientAdresse2;
        string clientCodePostale;
        string clientVille;
        string typeLicence;

        #endregion

        #region..Proprietée..

        public string ClientCode
        {
            get { return clientCode; }
            set { clientCode = value; }
        }
        public string TypeLicences
        {
            get { return typeLicence; }
            set { typeLicence = value; }
        }
        public string ClientPrenom
        {
            get { return clientPrenom; }
            set { clientPrenom = value; }
        }
        public string ClientAdresse1
        {
            get { return clientAdresse1; }
            set { clientAdresse1 = value; }
        }
        public string ClientAdresse2
        {
            get { return clientAdresse2; }
            set { clientAdresse2 = value; }
        }
        public string ClientVille
        {
            get { return clientVille; }
            set { clientVille = value; }
        }
        public string ClientCodePostal
        {
            get { return clientCodePostale; }
            set { clientCodePostale = value; }
        }

        #endregion

        #region..CTOR..

        public Client()
        {

        }

        #endregion
    }
}
