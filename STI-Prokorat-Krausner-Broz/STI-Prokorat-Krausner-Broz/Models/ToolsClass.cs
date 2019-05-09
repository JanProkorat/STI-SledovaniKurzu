using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace STIProkoratKrausnerBroz.Models
{
    public class ToolsClass
    {

        public List<Currency> Currencies { get; set; }
        public string[] MonitoredCurrencies { get; set; }
        public List<Deal> BestDeals { get; set; }

        public ToolsClass(){
            Currencies = new List<Currency>();
            MonitoredCurrencies = new string[] { "AUD", "DKK", "EUR", "HRK", "CAD", "HUF",
                "NOK", "PLN", "RON", "RUB", "SEK", "CHF", "JPY", "USD", "GBP"};
            BestDeals = new List<Deal>();

        }

        public void calculateBestDeals(){
            foreach(Currency cur in Currencies){
                Deal deal = new Deal();
                deal.Country = cur.state;
                deal.CurrencyName = cur.name;
                Date date = cur.Dates.Find(d => d.date == cur.Dates.Max(Date => Date.date));
                Bank cnb = date.Banks.Find(bank => bank.name.ToUpper() == "CNB");
                for(int i = 0; i < date.Banks.Count - 1; i++) {
                    if ((Math.Abs(date.Banks[i].saleVal - cnb.saleVal) > deal.BestSale) && date.Banks[i].name.ToUpper() != "CNB"){
                        deal.BestSale = date.Banks[i].saleVal;
                        deal.BestSaleBank = date.Banks[i].name;
                    }
                    if ((Math.Abs(date.Banks[i].purchaseVal - cnb.purchaseVal) < deal.BestBuy) && date.Banks[i].name.ToUpper() != "CNB"){
                        deal.BestBuy = date.Banks[i].purchaseVal;
                        deal.BestBuyBank = date.Banks[i].name;
                    }
                }
                if (cur.Dates.Count == 1){
                    deal.Recommendation = "Nedostatek dat";
                }else{
                    if (cur.Dates[cur.Dates.Count - 1].Banks.Find(Bank => Bank.name.ToLower() == "cnb").saleVal <=
                        cur.Dates[cur.Dates.Count - 2].Banks.Find(Bank => Bank.name.ToLower() == "cnb").saleVal){
                        deal.Recommendation = "Kupuj";
                    }else {
                        deal.Recommendation = "Prodej";
                    }
                }
                BestDeals.Add(deal);
            }
        }

        public Boolean testVersion(double versionProg)
        {
            string url = "https://github.com/JanProkorat/STI-KontrolaVerze/blob/master/version.txt";
            if (!this.testUrlReachable(url)){
                return true;
            }
            String tmp = parseVersion(getHTML(url));
            double versionWeb = Convert.ToDouble(tmp.Replace(".",","));
            return versionProg == versionWeb;
        }

        public String parseVersion(string html)
        {
            string version = "";
            String[] separators = new String[] { "< td id = \"LC1\" class=\"blob-code blob-code-inner js-file-line\">","</td>"};
            String[] datas = html.Split(separators, StringSplitOptions.None);
            string tmp = datas[1];
            datas = tmp.Split(">");
            version = datas[1];
            return version;
        }

        internal void sortCurrencies()
        {
            List<Currency> tmp = Currencies.OrderBy(Currency => Currency.state).ToList();
            Currencies.Clear();
            for (int i = tmp.Count - 1; i >= 0; i--){
                Currencies.Add(tmp[i]);
            }
        }

        internal void sortBestDeals()
        {
            List<Deal> tmp = BestDeals.OrderBy(Deal=> Deal.Country).ToList();
            BestDeals.Clear();
            for (int i = 0; i < tmp.Count; i++){
                BestDeals.Add(tmp[i]);
            }
        }

        public String getExchangeListUrl(string name)
        {
            name = name.ToUpper();
            String tmpUrl = "";
            switch (name) {
                case "CNB":
                    return "https://www.cnb.cz/cs/financni_trhy/devizovy_trh/kurzy_devizoveho_trhu/denni_kurz.txt";
                case "CSOB":
                    tmpUrl = "https://www.kurzy.cz/kurzy-men/kurzovni-listek/nr/csob/D-";
                    break;
                case "CS":
                    tmpUrl = "https://www.kurzy.cz/kurzy-men/kurzovni-listek/nr/ceska-sporitelna/D-";
                    break;
                case "RB":
                    tmpUrl = "https://www.kurzy.cz/kurzy-men/kurzovni-listek/nr/raiffeisenbank/D-";
                    break;
                case "KB":
                    tmpUrl = "https://www.kurzy.cz/kurzy-men/kurzovni-listek/nr/komercni-banka/D-";
                    break;
                default:
                    return "Error";
            }
            //int tmp = (int)(ClockInfoFromSystem.DayOfWeek + 6) % 7;
            int dayNumberOfWeek = (int)DateTime.Today.DayOfWeek;
            DateTime dat;
            switch (dayNumberOfWeek) {
                case 6:
                    dat = DateTime.Today.AddDays(-1);
                    break;
                case 0:
                    dat = DateTime.Today.AddDays(-2);
                    break;
                default:
                    dat = DateTime.Today;
                    break;
            }
            tmpUrl = tmpUrl + dat.ToString("dd.MM.yyyy") + "/";
            Console.WriteLine("");
            return tmpUrl;

        }

        internal void createCurrency(string folderPath)
        {
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.txt"))
            {
                if(file != "tmp_files/last.txt")
                {

                    List<string> lines = File.ReadAllLines(file).ToList();
                    string[] tmp = Regex.Split(file, @"\D+");
                    DateTime myDate = DateTime.ParseExact(tmp[1] + "." + tmp[2] + "." + tmp[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                    string bankName = "";
                    DataTable table = new DataTable();
                    if (file.Contains("cnb"))
                    {
                        bankName = "cnb";
                        createTable(table, lines, '|', 1);
                    }
                    else if (!file.Contains("last"))
                    {
                        bankName = lines[0].Split(" ")[1];
                        createTable(table, lines, ';', 1);
                    }
                    loadCurrenciesToList(table);
                    foreach (Currency curr in Currencies)
                    {
                        if (!curr.Dates.Any(Date => Date.date.Day == myDate.Day &&
                            Date.date.Month == myDate.Month && Date.date.Year == myDate.Year))
                        {
                            curr.Dates.Add(new Date(myDate));
                        }
                    }
                    loadBanksToDates(table, bankName, myDate);
                }

            }

        }

        private void loadBanksToDates(DataTable table, String bankName, DateTime localDate){
            foreach(DataRow row in table.Rows){
                foreach(Currency curr in Currencies){
                    if(curr.name == row["kód"].ToString()){
                        if (bankName == "cnb"){
                            curr.Dates.Find(Date => Date.date == localDate).
                            createBank(bankName, 0, formatPlatform(row["kurz"].ToString()), 0);
                        }
                        else{
                            curr.Dates.Find(Date => Date.date == localDate).
                            createBank(bankName, formatPlatform(row["nakup"].ToString()),
                            formatPlatform(row["prodej"].ToString()), formatPlatform(row["stred"].ToString()));
                        }
                    }      
                }
            }
        }

        private void loadCurrenciesToList(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                if (!Currencies.Any(Currency => Currency.name == row["kód"].ToString()) && 
                    MonitoredCurrencies.Contains(row["kód"].ToString())){
                    Currencies.Add(new Currency(row["kód"].ToString(), row["země"].ToString()));
                }
            }
        }

        private void createTable(DataTable dt, List<string> lines, char separator, int skip)
        {
            for (int i = 0; i < 1; i++)
            {
                lines.RemoveAt(i);
            }
            lines.RemoveAll(string.IsNullOrWhiteSpace);
            string[] tmp = lines[0].Split(separator);
            string[] headers = tmp.Distinct().ToArray();
            foreach (string header in headers)
            {

                dt.Columns.Add(new DataColumn(header.ToLower()));
            }
            foreach (string itemLine in lines.Skip(skip))
            {
                string[] items = itemLine.Split(separator);
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
        }

        private double formatPlatform(String s)
        {
            if(s.Trim() == "-")
            {
                s = "0";
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                //Console.WriteLine(s);
                return double.Parse(s.Replace(",", "."));
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                return double.Parse(s.Replace(".",","));
            }
            return double.Parse(s);
        }

        public Boolean getExchangeRatesFileTxt(string bank, string startupPath)
        {
            //Save file from url as tmp-/bank/-/date/.txt
            //return true if download was completed else return false
            bank = bank.ToLower();
            String url = getExchangeListUrl(bank);
            if (!testUrlReachable(url))
            {
                return false;
            }
            WebClient wc = new WebClient();
            String path = startupPath + "tmp-" + bank + "-" + DateTime.Today.ToString("dd-MM-yyyy") + ".txt";
            string data = "";
            if (bank.ToLower() == "cnb")
            {
                wc.DownloadFile(new System.Uri(url), path);
                return true;
            }
            else if (bank.ToLower() == "kb" || bank.ToLower() == "rb")
            {
                data = normalizetoTXTa(parseData(getHTML(url)), bank);
            } else
            {
                data = normalizetoTXTb(parseData(getHTML(url)), bank);
            }

            if (!File.Exists(path))
            {
                File.Create(path).Close();
                File.WriteAllText(path,data);
            }
            else if (File.Exists(path))
            {
                File.WriteAllText(path, data);
            }

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
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;
            double time = (double)hour + ((double)minute / 100.0);
            //Console.WriteLine("Time: " + time.ToString());
            if (daydiff == 0)
            {
                return true;
            }
            else if (time > 18.05)
            {
                return false;
            }
            else
            {
                return true;
            }
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

        private string normalizetoTXTa(string data, String Bank)
        {
            String[] datas = data.Split('\n');
            string respond = DateTime.Today.ToString("dd.MM.yyyy") + " " + Bank + Environment.NewLine + "země;kód;množství;nakup;prodej;stred;nakup;prodej;stred" + Environment.NewLine;
            for (int i = 8; i < datas.Length - 12; i = i + 12)
            {
                respond = respond + datas[i] + ";" + datas[i + 1] + ";" + datas[i + 2] + ";" + datas[i + 4] + ";" + datas[i + 5] + ";" + datas[i + 6] + ";" + datas[i + 8] + ";" + datas[i + 9] + ";" + datas[i + 10] + Environment.NewLine;
            }
            return respond;
        }

        private string normalizetoTXTb(string data, String Bank)
        {
            String[] datas = data.Split('\n');
            string respond = DateTime.Today.ToString("dd.MM.yyyy") + " " + Bank + Environment.NewLine + "země;kód;množství;nakup;prodej;stred;nakup;prodej;stred" + Environment.NewLine;
            for (int i = 8; i < datas.Length - 11; i = i + 11)
            {
                respond = respond + datas[i] + ";" + datas[i + 1] + ";" + datas[i + 2] + ";" + datas[i + 3] + ";" + datas[i + 4] + ";" + datas[i + 5] + ";" + datas[i + 7] + ";" + datas[i + 8] + ";" + datas[i + 9] + Environment.NewLine;
            }

            return respond;
        }


        private string getHTML(string url)
        {
            String data = "";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //EncodingProvider provider = System.Text.EncodingProvider;
            //Encoding.RegisterProvider(provider);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                Stream receiveStream = response.GetResponseStream();
                StreamReader readStream = null;
                if (response.CharacterSet == null)
                {
                    readStream = new StreamReader(receiveStream);
                }
                else {
                    if (response.CharacterSet == "windows-1250")
                    { 
                        readStream = new StreamReader(receiveStream, CodePagesEncodingProvider.Instance.GetEncoding(1250));
                    }
                    else
                    {
                        readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));
                    }
                }
                data = readStream.ReadToEnd();
                response.Close();
                readStream.Close();
            }
            return data;
        }

        private string parseData(string data)
        {
            data = Regex.Replace(data, "<script.*?//script>", string.Empty);
            String[] separators = new String[] { "<table border=\"0\" width=\"660\" cellpadding =\"1\" cellspacing =\"1\" class=\"pd pdw\">",
                                                    "</table>"};
            String[] datas = data.Split(separators, StringSplitOptions.None);
            data = Regex.Replace(datas[1], "<.*?>", string.Empty);
            data = data.Replace("\r", string.Empty);
            data = data.Replace("\t", string.Empty);
            Regex regex = new Regex("[ ]{2,}", RegexOptions.None);
            data = regex.Replace(data, "\n");
            data = data.Replace("\n ", "\n");
            data = data.Replace("&nbsp;", string.Empty);

            regex = new Regex("[\n]{2,}", RegexOptions.None);
            data = regex.Replace(data, "\n");
            data = data.Replace("\n", ";");
            data = data.Replace("; ", "\n");
            data = data.Replace(" ;", "");
            data = data.Replace("\n\n", "\n-\n");
            data = data.Replace("\n\n", "\n-\n");
            data = data.Replace("\n;", "\n");
            data = data.Replace(";", "\n");
            return data;
        }
    }
}