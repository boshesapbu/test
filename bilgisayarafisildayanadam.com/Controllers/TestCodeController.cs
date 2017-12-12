using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bilgisayarafisildayanadam.com.Database;
using bilgisayarafisildayanadam.com.Log;
using MA.Dal;
using MA.Database.Procedures;
using MA.Database.Functions.Table;
using MA.Database.Functions.Scalar;
using System.Data.SqlClient;

namespace bilgisayarafisildayanadam.com.Controllers
{
    public class TestCodeController : Controller
    {
        // GET: TestCode
        [Route("TestCode")]
        public ActionResult Index(procedure_insert_users parameter)
        {
            var _con = ConnectionOptions.ConnectionNew;
            _con.Open();

            var _list = function_list_users.Get(
                _con,
                function_admin_user_id.Get(_con).data,
                "dfgdgd");
            _con.Close();

            return View();
        }
    }
}