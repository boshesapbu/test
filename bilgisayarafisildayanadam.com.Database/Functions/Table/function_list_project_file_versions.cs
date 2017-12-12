using MA.Dal;
using MA.Dao;
using MA.Dao.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Database.Functions.Table
{
    [MADataName(Name = "[dbo].[function_list_project_file_versions](@process_user_id,@project_id,@search_parameter)")]
    public class function_list_project_file_versions : MADaoViewOrFunc<function_list_project_file_versions>
    {
        #region Variables
        
[MADataColumn]
public string project_file_version_id { get; set; }

[MADataColumn]
public string project_file_id { get; set; }

[MADataColumn]
public string user_id { get; set; }

[MADataColumn]
public string file_buffer_md5 { get; set; }

[MADataColumn]
public bool file_deleted { get; set; }

[MADataColumn]
public DateTime update_date { get; set; }

[MADataColumn]
public string deleted_code { get; set; }
        #endregion

        #region Methods
        public static List<function_list_project_file_versions> Get(MAData.Connection con, string process_user_id, string project_id, string search_parameter, params MAData.Sql.NameAndOrder[] parameters)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.Select(
                        ViewOrFunctionName,
                        MAData.Sql.AllColumns,
                        orderByCommand: MAData.Sql.OrderByCommand(parameters)
                        ), new MAData.Parameter("@process_user_id", process_user_id), new MAData.Parameter("@project_id", project_id), new MAData.Parameter("@search_parameter", search_parameter)
                )
                );
        }
        public static List<function_list_project_file_versions> Get(MAData.Connection con, string process_user_id, string project_id, string search_parameter, int? startRowIndex, int? endRowIndex, params MAData.Sql.NameAndOrder[] parameters)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.SelectPage(
                        MAData.Sql.Select(
                            ViewOrFunctionName,
                            MAData.Sql.AllColumns
                            ), MAData.Sql.OrderByCommand(parameters), startRowIndex, endRowIndex)
                    , new MAData.Parameter("@process_user_id", process_user_id), new MAData.Parameter("@project_id", project_id), new MAData.Parameter("@search_parameter", search_parameter)
                )
                );
        }
        #endregion
    }
}
