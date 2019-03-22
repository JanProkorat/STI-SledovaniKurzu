using System;
using System.Data;
using System.Globalization;

namespace STIProkoratKrausnerBroz.Models
{
    public class TableObject
    {
        public DateTime date { get; set; }
        public string bankName { get; set; }
        public DataTable table { get; set; }


        public TableObject(string date, string bankName, DataTable table)
        {
            this.date = DateTime.ParseExact(date, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            this.bankName = bankName;
            this.table = table;
        }
    }
}
