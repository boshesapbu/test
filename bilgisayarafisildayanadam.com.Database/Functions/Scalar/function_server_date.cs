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
    [MADataName(Name = "[dbo].[function_server_date]()")]
    public class function_server_date : MADaoViewOrFunc<function_server_date>
    {
        #region Variables
        [MADataColumn(Name = "")]
        public DateTime data { get; set; }
        #endregion

        #region Methods
        public static function_server_date Get(MAData.Connection con)
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
