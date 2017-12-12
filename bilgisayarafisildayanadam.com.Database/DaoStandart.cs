using MA.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bilgisayarafisildayanadam.com.Database
{
    public static class DaoStandart
    {
        #region Variables

        #region Deleted Code
        #region Consts
        public const string DeletedCode_Normal = "NORMAL";
        public const string DeletedCode_Deleted = "DELETED";
        #endregion

        public static MAData.Parameter DeletedCode_Normal_Parameter
        {
            get
            {
                return new MAData.Parameter("@deletedCode", DeletedCode_Normal);
            }
        }
        public static MAData.Parameter DeletedCode_Deleted_Parameter
        {
            get
            {
                return new MAData.Parameter("@deletedCode", DeletedCode_Deleted);
            }
        }

        #endregion

        #endregion
    }
}
