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
    [MADataName(Name = "[dbo].[procedure_update_project_authorities]")]
    public class procedure_update_project_authorities : MADaoProcedure<procedure_update_project_authorities, procedure_update_project_authorities.Result>
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

[MaxLength(1900, ErrorMessage = "")]
[MADataColumn]
public string update_users_combine { get; set; }

[MaxLength(1900, ErrorMessage = "")]
[MADataColumn]
public string delete_users_combine { get; set; }

[MaxLength(1900, ErrorMessage = "")]
[MADataColumn]
public string update_project_files_users_combine { get; set; }
        #endregion

        #region Methods
        protected override Result GetResultFromCommand(MAData.Command command)
        {
            return command.GetFirstRowColumnEnum<Result>();
        }
        #endregion
    }
}
