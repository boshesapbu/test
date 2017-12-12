using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace bilgisayarafisildayanadam.com.Log
{
    public static class LogOptions
    {
        #region Enums
        public enum ProcessType
        {
            REQUEST,
            RESPONSE,
            INSERT,
            UPDATE,
            DELETE,
            SELECT_ROW,
            SELECT_ROWS
        }
        #endregion

        #region Variables
        static string logFilePath = null;
        internal static string LogFilePath
        {
            get
            {
                if (string.IsNullOrEmpty(logFilePath))
                    logFilePath = HttpContext.Current.Server.MapPath(ConfigurationManager.AppSettings["LogFileDirectory"]);
                return logFilePath;
            }
        }
        static LogMA.Log log_ = null;
        static LogMA.Log log
        {
            get
            {
                if (log_ == null)
                    log_ = new LogMA.Log(
                        new string[]
                        {
                            "IP",
                            "PROCESS_USER_ID",
                            "TYPE",
                            "NAME",
                            "DATAS",
                            "DATETIME_YEAR",
                            "DATETIME_MONTH",
                            "DATETIME_DAY",
                            "DATETIME_HOUR",
                            "DATETIME_MINUTE",
                            "DATETIME_SECOND"
                        },
                        LogFilePath,
                        "",
                        "yyyy"
                        );
                return log_;
            }
        }
        #endregion

        #region Methods
        public static void Add(
            int process_user_id,
            ProcessType type,
            string name,
            object datas
            )
        {
            var _dt = DateTime.Now;
            log.Add(
                getIPAddress(),
                process_user_id.ToString(),
                type.ToString(),
                name,
                JsonConvert.SerializeObject(datas),
                _dt.Year.ToString(),
                _dt.Month.ToString(),
                _dt.Day.ToString(),
                _dt.Hour.ToString(),
                _dt.Minute.ToString(),
                _dt.Second.ToString()
                );
        }

        static string getIPAddress()
        {
            HttpContext _context = HttpContext.Current;
            string _ipAddress = _context.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(_ipAddress))
            {
                string[] _addresses = _ipAddress.Split(',');
                if (_addresses.Length != 0)
                    return _addresses[0];
            }

            return _context.Request.ServerVariables["REMOTE_ADDR"];
        }
        #endregion
    }
}
