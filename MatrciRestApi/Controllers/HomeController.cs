using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MatrciRestApi.Controllers
{
    public class HomeController : ApiController
    {
        [HttpPost]
        public bool AddNewResult(string emis)//, [FromBody]string centreNo, [FromBody]string name, string wrote2014,
            //[FromBody]string passed2014, [FromBody]string wrote2015, [FromBody]string passed2015, string wrote2016, string passed2016)
        {
            // write to the database
            return true;
        }

        [HttpGet]
        public string GetAllMatricResults()
        {
            // read all results from the database
            return "tau";
        }
    }
}
