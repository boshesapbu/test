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
    [MADataName(Name = "[dbo].[function_exists_project_authority_delete](@process_user_id,@project_id)")]
    public class function_exists_project_authority_delete : MADaoViewOrFunc<function_exists_project_authority_delete>
    {
        #region Variables
        [MADataColumn(Name = "")]
        public bool data { get; set; }
        #endregion

        #region Methods
        public static function_exists_project_authority_delete Get(MAData.Connection con, string process_user_id, string project_id)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.SelectData(
                        ViewOrFunctionName
                        ), new MAData.Parameter("@process_user_id", process_user_id), new MAData.Parameter("@project_id", project_id)
                )
                ).FirstOrDefault();
        }
        #endregion
    }
}
