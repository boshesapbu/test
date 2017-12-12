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
    [MADataName(Name = "[dbo].[function_list_string_split](@sString,@cDelimiter)")]
    public class function_list_string_split : MADaoViewOrFunc<function_list_string_split>
    {
        #region Variables
        
[MADataColumn]
public string value { get; set; }
        #endregion

        #region Methods
        public static List<function_list_string_split> Get(MAData.Connection con, string sString, string cDelimiter, params MAData.Sql.NameAndOrder[] parameters)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.Select(
                        ViewOrFunctionName,
                        MAData.Sql.AllColumns,
                        orderByCommand: MAData.Sql.OrderByCommand(parameters)
                        ), new MAData.Parameter("@sString", sString), new MAData.Parameter("@cDelimiter", cDelimiter)
                )
                );
        }
        public static List<function_list_string_split> Get(MAData.Connection con, string sString, string cDelimiter, int? startRowIndex, int? endRowIndex, params MAData.Sql.NameAndOrder[] parameters)
        {
            return Select(
                new MAData.Command(
                    con,
                    MAData.Sql.SelectPage(
                        MAData.Sql.Select(
                            ViewOrFunctionName,
                            MAData.Sql.AllColumns
                            ), MAData.Sql.OrderByCommand(parameters), startRowIndex, endRowIndex)
                    , new MAData.Parameter("@sString", sString), new MAData.Parameter("@cDelimiter", cDelimiter)
                )
                );
        }
        #endregion
    }
}
