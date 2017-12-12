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
    [MADataName(Name = "[dbo].[function_exists_project_file_path_authority](@process_user_id,@project_id,@file_path_md5)")]
    public class function_exists_project_file_path_authority : MADaoViewOrFunc<function_exists_project_file_path_authority>
    {
        #region Variables
        [MADataColumn(Name = "")]
        public bool data { get; set; }
        #endregion

        #region Methods
        public static function_exists_project_file_path_authority Get(MAData.Connection con, string process_user_id, string project_id, string file_path_md5)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.SelectData(
                        ViewOrFunctionName
                        ), new MAData.Parameter("@process_user_id", process_user_id), new MAData.Parameter("@project_id", project_id), new MAData.Parameter("@file_path_md5", file_path_md5)
                )
                ).FirstOrDefault();
        }
        #endregion
    }
}
