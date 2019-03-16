using System;
using System.Collections.Generic;

namespace STIProkoratKrausnerBroz.Models
{
    public class Bank
    {
        public String name { get; set; }
        public double changeVal { get; set; }
        public double purchaseVal { get; set; }
        public double centerVal { get; set; }
        public double saleVal { get; set; }

        public Bank(string name, double change, double purchase, double sale, double center)
        {
            this.name = name;
            this.changeVal = change;
            this.purchaseVal = purchase;
            this.centerVal = center;
            this.saleVal = sale;

        }
    }
}
