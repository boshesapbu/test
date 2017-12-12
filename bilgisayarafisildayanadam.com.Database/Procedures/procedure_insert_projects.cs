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
    [MADataName(Name = "[dbo].[procedure_insert_projects]")]
    public class procedure_insert_projects : MADaoProcedure<procedure_insert_projects, procedure_insert_projects.Result>
    {
        #region Enums
        public enum Result
        {
            PROCESS_USER_ID_ERROR,
            PROJECT_REPEAT,
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

[MaxLength(300, ErrorMessage = "")]
[MADataColumn]
public string name { get; set; }

[MaxLength(500, ErrorMessage = "")]
[MADataColumn]
public string description { get; set; }

[MaxLength(10, ErrorMessage = "")]
[MADataColumn]
public string deleted_code { get; set; }
        #endregion

        #region Methods
        protected override Result GetResultFromCommand(MAData.Command command)
        {
            return command.GetFirstRowColumnEnum<Result>();
        }
        #endregion
    }
}
