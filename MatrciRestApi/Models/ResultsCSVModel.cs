using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MatrciRestApi.Models
{
    public class ResultsCSVModel
    {
        public string emis { get; set; }
        public string centreNo { get; set; }
        public string name { get; set; }
        public string year { get; set; }
        public string wrote2014 { get; set; }
        public string passed2014 { get; set; }
        public string wrote2015 { get; set; }
        public string passed2015 { get; set; }
        public string wrote2016 { get; set; }
        public string passed2016 { get; set; }
    }
}