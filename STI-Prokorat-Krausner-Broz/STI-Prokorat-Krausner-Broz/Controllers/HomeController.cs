using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STI_Prokorat_Krausner_Broz.Models;
using STIProkoratKrausnerBroz.Models;

namespace STI_Prokorat_Krausner_Broz.Controllers
{
    public class HomeController : Controller
    {
        private ToolsClass t = new ToolsClass();
        Timer timer = null;
        double Version = 1.2;
        //Timer timerTest = null;
        int i = 0;

        public IActionResult Index()
        {
            this.downloadTXT();
            this.testVersion();
            this.setTimerAndStart();
            t.createCurrency("tmp_files/");
            sortCurrencies(t);
            return View(t);
        }

        private void sortCurrencies(ToolsClass t)
        {
            t.sortCurrencies();
            foreach(Currency c in t.Currencies)
            {
                c.sortDates();
                foreach(Date d in c.Dates)
                {
                    d.sortBanks();
                }
            }

        }

        public ActionResult TableView(){
            TableData td = new TableData();
            td.loadFiles("tmp_files/");
            td.sortList();
            return View(td);
        }

        private void setTimerAndStart()
        {
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            timer = new Timer(this.Timer_Elapsed,autoEvent, 3600000, 3600000);

            //timerTest = new Timer(this.TimerTest_Elapsed, autoEvent, 1000, 1000);

        }

        private void Timer_Elapsed(Object stateInfo)
        {
            this.downloadTXT();
            this.testVersion();
        }

        private void TimerTest_Elapsed(Object stateInfo)
        {
            Console.WriteLine("Fuck  this shitelapsed!!!! " + i.ToString() + " times!!");
            i++;
        }

        private void downloadTXT()
        {
            String[] bankCodes = new String[5];
            bankCodes[0] = "CNB";
            bankCodes[1] = "CSOB";
            bankCodes[2] = "CS";
            bankCodes[3] = "RB";
            bankCodes[4] = "KB";
            int bankCount = 0;
            if (!t.testLastDownload())
            {
                foreach (String bankCode in bankCodes)
                {
                    if (t.getExchangeRatesFileTxt(bankCode, "tmp_files/"))
                    {
                        ViewBag.Zprava = "Povedlo se stáhnout soubor od " + bankCode;
                    }
                    bankCount++;
                }
                if (bankCount == bankCodes.Length)
                {
                    t.setLastDownload();
                }
            }
        }

        private void testVersion()
        {
            if (t.testVersion(Version))
            {
                Console.WriteLine("Verze je aktualni");
            }
            else{
                Console.WriteLine("Stahnete si novou verzi programu!");
            }
            int x = 0;
        }


    }
}
