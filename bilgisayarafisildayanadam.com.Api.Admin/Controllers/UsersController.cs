using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MA.Database.Procedures;

namespace bilgisayarafisildayanadam.com.Api.Admin.Controllers
{
    public class UsersController : ApiController
    {
        public void Insert(procedure_insert_users user)
        {
            user.process_user_id = "";
            user.user_id = Guid.NewGuid().ToString();
            var _resultService = new Takbis().Run(256);
        }

    }

    public interface IServiceMA<TParameterModel, TResult>
    {
        TResult Run(TParameterModel parameter);
    }
    
    public class Takbis : IServiceMA<int, Takbis>
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public DateTime dogum_tarihi { get; set; }

        public Takbis Run(int parameter)
        {
            return null;
        }
    }
}