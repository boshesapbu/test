using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgisayarafisildayanadam.com.Security
{
    public static class SecurityOptions
    {
        #region Variables
        static string securityKeyString = null;
        internal static string SecurityKeyString
        {
            get
            {
                if (string.IsNullOrEmpty(securityKeyString))
                    securityKeyString = ConfigurationManager.AppSettings["SecurityKey"];
                return securityKeyString;
            }
        }

        static Nullable<SecurityMA.Security> key = null;
        internal static SecurityMA.Security Key
        {
            get
            {
                if (key == null)
                    key = SecurityMA.Security.New(SecurityKeyString);
                return key.Value;
            }
        }

        static Encoding CryptoEncoding
        {
            get
            {
                return Encoding.UTF8;
            }
        }
        #endregion

        #region Methods
        public static string EncryptionStringToBase64(string value)
        {
            return Key.EncryptionStringToBase64(value, CryptoEncoding);
        }
        public static string DecryptionStringFromBase64(string value)
        {
            return Key.DecryptionStringFromBase64(value, CryptoEncoding);
        }
        public static string Md5(string value)
        {
            return Key.MD5String(value, CryptoEncoding);
        }
        #endregion
    }
}
