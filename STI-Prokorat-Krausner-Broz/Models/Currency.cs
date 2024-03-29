﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace STIProkoratKrausnerBroz.Models
{
    public class Currency
    {
        public List<Date> Dates { get; set; }
        public string Name { get; set; }
        public string State { get; set; }

        public Currency(string name, string state )
        {
            this.State = state;
            this.Name = name;
            this.Dates = new List<Date>();
        }

        public void sortDates()
        {
            List<Date> tmp = Dates.OrderBy(Date => Date.date).ToList();
            Dates.Clear();
            for (int i = tmp.Count - 1; i >= 0; i--)
            {
                Dates.Add(tmp[i]);
            }
        }
    }
}
