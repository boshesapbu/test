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
    [MADataName(Name = "[dbo].[function_convert_md5](@str)")]
    public class function_convert_md5 : MADaoViewOrFunc<function_convert_md5>
    {
        #region Variables
        [MADataColumn(Name = "")]
        public string data { get; set; }
        #endregion

        #region Methods
        public static function_convert_md5 Get(MAData.Connection con, string str)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.SelectData(
                        ViewOrFunctionName
                        ), new MAData.Parameter("@str", str)
                )
                ).FirstOrDefault();
        }
        #endregion
    }
}
