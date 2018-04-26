using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnswerDigital2.Controllers
{
    public class PeopleController : ApiController
    {
        public IEnumerable<PeopleController> GetAllData()
        {
            System.Threading.Thread.Sleep(1500);
           Models. MyDatabase db = new Models.MyDatabase();
            var data = db.People.ToList();

            return data;
        }
    }
}
