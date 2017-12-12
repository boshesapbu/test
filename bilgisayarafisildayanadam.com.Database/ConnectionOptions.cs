using MA.Dal;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace bilgisayarafisildayanadam.com.Database
{
    public static class ConnectionOptions
    {
        #region Variables
        static string databaseConnectionString = null;
        public static string DatabaseConnectionString
        {
            get
            {
                if (string.IsNullOrEmpty(databaseConnectionString))
                    databaseConnectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                return databaseConnectionString;
            }
        }

        #region DAL
        public static MAData.Connection ConnectionNew
        {
            get
            {
                return new MAData.Connection(DatabaseConnectionString);
            }
        }
        #endregion
        #endregion

        #region Methods
        #endregion
    }
}
