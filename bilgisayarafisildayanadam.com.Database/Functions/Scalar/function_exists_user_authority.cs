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
    [MADataName(Name = "[dbo].[function_exists_user_authority](@process_user_id,@authority_name)")]
    public class function_exists_user_authority : MADaoViewOrFunc<function_exists_user_authority>
    {
        #region Variables
        [MADataColumn(Name = "")]
        public bool data { get; set; }
        #endregion

        #region Methods
        public static function_exists_user_authority Get(MAData.Connection con, string process_user_id, string authority_name)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.SelectData(
                        ViewOrFunctionName
                        ), new MAData.Parameter("@process_user_id", process_user_id), new MAData.Parameter("@authority_name", authority_name)
                )
                ).FirstOrDefault();
        }
        #endregion
    }
}
