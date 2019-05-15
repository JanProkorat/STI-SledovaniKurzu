using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace STIProkoratKrausnerBroz.Models
{
    public class TableData
    {
        public List<TableObject> Tables { get; set; }

        public TableData(string filePath)
        {
            this.Tables = loadFiles(filePath);
        }

        public List<TableObject> loadFiles(string folderPath)
        {
            List<TableObject> tmpList = new List<TableObject>();
            foreach (string file in Directory.EnumerateFiles(folderPath, "*.txt"))
            {
                if (file != "tmp_files/last.txt")
                {
                    string[] tmp = Regex.Split(file, @"\D+");
                    List<string> lines = File.ReadAllLines(file).ToList();
                    string bankName = "";
                    DataTable table = new DataTable();
                    if (file.Contains("cnb"))
                    {
                        bankName = "cnb";
                        createTable(bankName,table, lines, '|', 1);
                    }
                    else if (!file.Contains("last"))
                    {
                        bankName = lines[0].Split(" ")[1];
                        createTable(bankName, table, lines, ';', 1);
                    }
                    tmpList.Add(new TableObject(tmp[1] + "." + tmp[2] + "." + tmp[3], bankName, table));
                }
            }
            calculateProfit(tmpList);
            return tmpList;
        }

        private void createTable(string bankName, DataTable dt, List<string> lines, char separator, int skip)
        {
            string[] MonitoredCurrencies = new string[] { "AUD", "DKK", "EUR", "HRK", "CAD", "HUF",
                "NOK", "PLN", "RON", "RUB", "SEK", "CHF", "JPY", "USD", "GBP"};
            for (int i = 0; i < 1; i++)
            {
                lines.RemoveAt(i);
            }
            lines.RemoveAll(string.IsNullOrWhiteSpace);
            string[] tmp = lines[0].Split(separator);
            List<string> headers = tmp.Distinct().ToList();
            if(bankName.ToLower() != "cnb"){
                headers.Add("Zisk na měně");
            }
            foreach (string header in headers)
            {
                dt.Columns.Add(new DataColumn(header.ToLower()));
            }
            foreach (string itemLine in lines.Skip(skip))
            {
                string[] items = itemLine.Split(separator);
                DataRow dr = dt.NewRow();
                for (int i = 0; i < tmp.Length; i++){
                    if (i > headers.Count - 1){
                        continue;
                    }
                    if (bankName.ToLower() != "cnb"){
                        if (i == headers.Count - 1){
                            dr[i] = "zatim nic";
                        }
                        if (i < headers.Count - 1){
                            dr[i] = items[i];
                        }
                    }else{
                        dr[i] = items[i];
                    }


                }
                if (MonitoredCurrencies.Contains(dr["kód"].ToString())){
                    dt.Rows.Add(dr);
                }
            }

        }


        internal void sortList()
        {
            List<TableObject> tmp = Tables.OrderBy(TableObject => TableObject.date).ToList();
            Tables.Clear();
            for (int i = tmp.Count-1; i >= 0; i--)
            {
                Tables.Add(tmp[i]);
            }

        }

        private void calculateProfit(List<TableObject> dataTable)
        {
            foreach(TableObject to in dataTable){
                if (to.bankName.ToUpper() == "CNB"){
                    continue;
                }else{
                    foreach(DataRow row in to.table.Rows) { 
                        row["zisk na měně"] = Math.Round(formatPlatform(row["prodej"].ToString()) - formatPlatform(row["nakup"].ToString()),3);
                    }
                }
            }
        }

        private double formatPlatform(String s)
        {
            if (s.Trim() == "-")
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
                return double.Parse(s.Replace(".", ","));
            }
            return double.Parse(s);
        }
    }
}
