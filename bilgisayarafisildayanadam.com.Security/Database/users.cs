using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgisayarafisildayanadam.com.Security.Database
{
    public static class users
    {
        #region Methods
        public static string GetLoginPassword(string login_password)
        {
            return SecurityOptions.Md5(login_password);
        }
        #endregion
    }
}
