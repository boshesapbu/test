using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgisayarafisildayanadam.com.Security
{
    public static class SecurityToken
    {
        #region Methods
        public static string GetToken(string data, DateTime maxDate)
        {
            return SecurityOptions.EncryptionStringToBase64(maxDate.Ticks + " " + data);
        }

        public static (string data, DateTime maxDate) GetDataAndMaxDate(string token)
        {
            string _decryptoToken = SecurityOptions.DecryptionStringFromBase64(token);
            int _spaceIndex = _decryptoToken.IndexOf(' ');
            return (
                data: _decryptoToken.Substring(_spaceIndex + 1), 
                maxDate: new DateTime(Convert.ToInt64(_decryptoToken.Substring(0, _spaceIndex))));
        }
        #endregion
    }
}
