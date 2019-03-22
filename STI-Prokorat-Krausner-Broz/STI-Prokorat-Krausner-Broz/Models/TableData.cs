using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace STIProkoratKrausnerBroz.Models
{
    public class TableData
    {
        public List<TableObject> Tables { get; set; }

        public TableData()
        {
            this.Tables = new List<TableObject>();
        }

        public void loadFiles(string folderPath)
        {
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
                        createTable(table, lines, '|', 1);
                    }
                    else if (!file.Contains("last"))
                    {
                        bankName = lines[0].Split(" ")[1];
                        createTable(table, lines, ';', 1);
                    }
                    Tables.Add(new TableObject(tmp[1] + "." + tmp[2] + "." + tmp[3], bankName, table));
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

        internal void sortList()
        {
            List<TableObject> tmp = Tables.OrderBy(TableObject => TableObject.date).ToList();
            Tables.Clear();
            for (int i = tmp.Count-1; i >= 0; i--)
            {
                Tables.Add(tmp[i]);
            }

        }
    }
}
