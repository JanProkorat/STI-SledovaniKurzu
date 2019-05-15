using System;
using System.Collections.Generic;
using System.Linq;

namespace STIProkoratKrausnerBroz.Models
{
    public class Date
    {
        public List<Bank> Banks { get; set; }
        public DateTime date { get; set; }

        public Date( DateTime date)
        {
            this.Banks = new List<Bank>();
            this.date = date;
        }

        public Date()
        {
            this.Banks = new List<Bank>();
            this.date = new DateTime();
        }

        public void createBank(string name, double purchase, double sale, double center)
        {
            Banks.Add(new Bank(name, purchase, sale, center));
        }

        public void sortBanks()
        {
            List<Bank> tmp = Banks.OrderBy(Bank => Bank.name).ToList();
            Banks.Clear();
            for (int i = tmp.Count - 1; i >= 0; i--)
            {
                Banks.Add(tmp[i]);
            }
        }
    }
}
