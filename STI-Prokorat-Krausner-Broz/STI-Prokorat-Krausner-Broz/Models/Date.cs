using System;
using System.Collections.Generic;

namespace STIProkoratKrausnerBroz.Models
{
    public class Date
    {
        public List<Bank> banks { get; set; }
        public DateTime date { get; set; }

        public Date( DateTime date)
        {
            this.banks = new List<Bank>();
            this.date = date;
        }

        public Date()
        {
            this.banks = new List<Bank>();
            this.date = new DateTime();
        }

        public void createBank(string name, double purchase, double sale, double center)
        {
            banks.Add(new Bank(name, purchase, sale, center));
        }
    }
}
