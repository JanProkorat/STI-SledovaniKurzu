using System;
using System.Collections.Generic;

namespace STIProkoratKrausnerBroz.Models
{
    public class Currency
    {
        public List<Date> dates { get; set; }
        public string name { get;set;}
        public string state { get; set; }


        public Currency(string name, string state )
        {
            this.state = state;
            this.name = name;
            this.dates = new List<Date>();

        }
    }
}
