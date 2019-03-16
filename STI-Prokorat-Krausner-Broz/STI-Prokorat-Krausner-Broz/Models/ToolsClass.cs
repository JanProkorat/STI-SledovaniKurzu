using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace STIProkoratKrausnerBroz.Models
{
    public class ToolsClass
    {

        public List<Currency> Currencies { get; set; }
        public string[] monitoredCurrencies { get; set; }

        public ToolsClass()
        {
            Currencies = new List<Currency>();
            monitoredCurrencies = new string[] { "AUD", "CNY", "EUR", "HRK", "CAD", "HUF", 
                "NOK", "PLN", "RON", "RUB", "SEK", "CHF", "TRY", "USD", "GBP"};
        }


        public String getExchangeListUrl(string name)
        {
            name = name.ToUpper();
            switch (name) {
                case "CNB":
                    return "https://www.cnb.cz/cs/financni_trhy/devizovy_trh/kurzy_devizoveho_trhu/denni_kurz.txt";
                case "CSOB":
                    return "https://www.csob.cz/portal/lide/kurzovni-listek/-/date/kurzy.txt";
                case "CS":
                    return "To Be Done!";
                case "RB":
                    return "To Be Done!";
                case "KB":
                    return "To Be Done!";
                default:
                    return "Error";
            }

        }

        internal void createCurrency(string folderPath)
        {
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.txt"))
            {
                if (file.Contains("cnb"))
                {
                    List<string> lines = File.ReadAllLines(file).ToList();
                    string myDate = lines[0].Split(" ")[0];
                    string bankName = "cnb";
                    DataTable dt = createCurrTable(lines);
                    //displayTable(dt);
                    foreach (DataRow row in dt.Rows)
                    {
                        Currency tmpC = null;
                        Currency c = null;
                        Date d = null;
                        if (Currencies.Any(Currency => Currency.name == row["kód"].ToString()))
                        {
                            // v seznamu existuje měna s daným kódem
                            tmpC = Currencies.Find(Currency => Currency.name == row["kód"].ToString());

                        }else if (monitoredCurrencies.Contains(row["kód"].ToString())){
                            // neexistuje, vytvoř novou měnu, pokud je v seznamu sledovaných měn
                            c = new Currency(row["kód"].ToString(), row["země"].ToString());
                        }

                        if (tmpC != null) { //existuje měna
                            if (tmpC.dates.Any(Date => Date.date.ToString() == myDate) &&
                             !file.Contains(DateTime.Parse(myDate).ToString("dd-MM-yyyy"))){
                                myDate = DateTime.Today.ToString("mm.DD.yyyy");
                            }else if (tmpC.dates.Any(Date => Date.date.ToString() == myDate)){
                                // existuje datum ve měně, přidej do něj novou banku s kurzem
                                Currencies.Find(Currency => Currency.name == row["kód"].ToString())
                                    .dates.Find(Date => Date.date.ToString() == myDate).
                                        createBank(bankName, 0, 0, formatPlatform(row["kurz"].ToString()), 0);
                            }else{
                                // neexistuje datum ve měně, vytvoř nové datum, a přidej do něj novou banku s kurzem
                                d = new Date(DateTime.ParseExact(myDate, "dd.MM.yyyy", CultureInfo.InvariantCulture));
                                d.createBank(bankName, 0, 0, formatPlatform(row["kurz"].ToString()), 0);
                                Currencies.Find(Currency => Currency.name == row["kód"].ToString()).dates.Add(d);
                            }
                        } else if(c != null) {    //neexistuje měna, mám novou vytvořenou
                            // v nové právě vytvořené měně nemůže být datum, vytvoř ho a vše přidej
                            d = new Date(DateTime.ParseExact(myDate, "dd.MM.yyyy", CultureInfo.InvariantCulture));
                            d.createBank(bankName, 0, 0, formatPlatform(row["kurz"].ToString()), 0);
                            c.dates.Add(d);
                            Currencies.Add(c);
                        }
                    }
                }
            }

        }


        /*Currency c = null;
                        if (Currencies.Any(Currency => Currency.name == row["kód"].ToString()) &&
                            Currencies.Any(Currency => Currency.name == row["země"].ToString())){
                            c = Currencies.Find(Currency => Currency.name == row["kód"].ToString());
                        }else{
                            if (monitoredCurrencies.Contains(row["kód"].ToString()))
                            {
                                c = new Currency(row["kód"].ToString(), row["země"].ToString());
                            }
                        }
                        if(c != null)
                        {
                            Date d;
                            if (c.dates.Any(Date => Date.date.ToString() == myDate))
                            {
                                d = c.dates.Find(Date => Date.date.ToString() == myDate);

                            }
                            else
                            {

                                d = new Date(DateTime.ParseExact(myDate, "dd.MM.yyyy", CultureInfo.InvariantCulture));

                            }

                            d.createBank(bankName, 0, 0, formatPlatform(row["kurz"].ToString()), 0);
                            c.dates.Add(d);
                            Currencies.Add(c);
                        }


*/
        private DataTable createCurrTable(List<string> lines)
        {
            DataTable dt = new DataTable();

            for (int i = 0; i < 1; i++)
            {
                lines.RemoveAt(i);
            }
            lines.RemoveAll(string.IsNullOrWhiteSpace);
            string[] tmp = lines[0].Split("|");
            string[] headers = tmp.Distinct().ToArray();
            foreach (string header in headers)
            {

                dt.Columns.Add(new DataColumn(header.ToLower()));
            }
            foreach (string itemLine in lines.Skip(1))
            {
                string[] items = itemLine.Split("|");
                DataRow dr = dt.NewRow();
                for (int i = 0; i < tmp.Length; i++)
                {
                    if (i > headers.Length - 1)
                    {
                        continue;
                    }
                    dr[i] = items[i];
                }
                dt.Rows.Add(dr);

            }
            return dt;
        }

        public Boolean getExchangeRatesFileTxt(string bank, string startupPath)
        {
            //Save file from url as tmp-/bank/-/date/.txt
            //return true if download was completed else return false
            if (testLastDownload())
            {
                return true;
            }
            bank = bank.ToLower();
            String url = getExchangeListUrl(bank);
            if (!testUrlReachable(url))
            {
                return false;
            }
            WebClient wc = new WebClient();
            String path = startupPath + "tmp-" + bank + "-" + DateTime.Today.ToString("dd-MM-yyyy") + ".txt";
            wc.DownloadFile(new System.Uri(url), path);
            return true;
        }



        public Boolean testUrlReachable(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 15000;
            request.Method = "HEAD";
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return response.StatusCode == HttpStatusCode.OK;
                }
            }
            catch (WebException)
            {
                return false;
            }
        }

        public double formatPlatform(String s)
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                return double.Parse(s.Replace(",", "."));
            }
            return double.Parse(s);
        }

        public DateTime getLastDownloadDate()
        {
            string[] lines = File.ReadAllLines("tmp_files/last.txt");
            //Console.WriteLine(lines[0]);
            return DateTime.ParseExact(lines[0].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
        }

        public Boolean testLastDownload()
        {
            DateTime date = DateTime.Parse(DateTime.Today.ToString().Split("")[0]);
            DateTime tmpDate = getLastDownloadDate();
            int daydiff = (int)((date - tmpDate).TotalDays);
            return daydiff == 0;
        }

        public void setLastDownload()
        {
            File.WriteAllText("tmp_files/last.txt", DateTime.Today.ToString("dd.MM.yyyy"));
        }

        private void displayTable(DataTable dt)
        {
            foreach (DataRow dr in dt.Rows)
            {
                foreach (DataColumn dc in dt.Columns)
                {
                    Console.WriteLine(dc.ColumnName);
                    Console.WriteLine(dr[dc].ToString());
                }
            }
        }
    }
}