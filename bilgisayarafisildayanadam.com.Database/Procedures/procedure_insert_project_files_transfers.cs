using MA.Dal;
using MA.Dao;
using MA.Dao.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MA.Database.Procedures
{
    [MADataName(Name = "[dbo].[procedure_insert_project_files_transfers]")]
    public class procedure_insert_project_files_transfers : MADaoProcedure<procedure_insert_project_files_transfers, procedure_insert_project_files_transfers.Result>
    {
        #region Enums
        public enum Result
        {
            PROCESS_USER_ID_ERROR,
            SUCCESS
        }
        #endregion

        #region Variables

        [MaxLength(36, ErrorMessage = "")][MinLength(36, ErrorMessage = "")]
[MADataColumn]
public string process_user_id { get; set; }

[MaxLength(36, ErrorMessage = "")][MinLength(36, ErrorMessage = "")]
[MADataColumn]
public string project_id { get; set; }

[MaxLength(4000, ErrorMessage = "")]
[MADataColumn]
public string file_path { get; set; }

[MaxLength(300, ErrorMessage = "")]
[MADataColumn]
public string file_name { get; set; }

[MaxLength(32, ErrorMessage = "")][MinLength(32, ErrorMessage = "")]
[MADataColumn]
public string file_buffer_md5 { get; set; }
        #endregion

        #region Methods
        protected override Result GetResultFromCommand(MAData.Command command)
        {
            return command.GetFirstRowColumnEnum<Result>();
        }
        #endregion
    }
}
