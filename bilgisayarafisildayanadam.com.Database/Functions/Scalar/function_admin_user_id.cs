using MA.Dal;
using MA.Dao;
using MA.Dao.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Database.Functions.Scalar
{
    [MADataName(Name = "[dbo].[function_admin_user_id]()")]
    public class function_admin_user_id : MADaoViewOrFunc<function_admin_user_id>
    {
        #region Variables
        [MADataColumn(Name = "")]
        public string data { get; set; }
        #endregion

        #region Methods
        public static function_admin_user_id Get(MAData.Connection con)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.SelectData(
                        ViewOrFunctionName
                        )
                )
                ).FirstOrDefault();
        }
        #endregion
    }
}
