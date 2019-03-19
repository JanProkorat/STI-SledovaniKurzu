using System;
using System.Collections.Generic;
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
        ToolsClass t = new ToolsClass();
        Timer timer = null;
        Timer timerTest = null;
        int i = 0;

        public IActionResult Index()
        {
            this.downloadTXT();
            this.setTimerAndStart();
            t.createCurrency("tmp_files/");
            foreach(Currency c in t.Currencies){
                Console.WriteLine(c.name+" "+c.state);
                foreach(Date d in c.dates)
                {
                    Console.WriteLine(d.date.ToString("dd.MM.yyyy"));
                    foreach (Bank b in d.banks)
                    {
                        Console.WriteLine(b.name+" "+b.saleVal);
                    }
                }
            }/*
            var currencies = t.Currencies.FindAll(Currency => Currency.name == "USD");
            foreach(var c in currencies)
            {
                Console.WriteLine(c.state + " " + c.name);
                foreach (Date d in c.dates)
                {
                    Console.WriteLine(d.date.ToString());
                }
            }
            */
            return View(t);
        }

        public void setTimerAndStart()
        {
            AutoResetEvent autoEvent = new AutoResetEvent(false);
            timer = new Timer(this.Timer_Elapsed,autoEvent, 3600000, 3600000);

            //timerTest = new Timer(this.TimerTest_Elapsed, autoEvent, 1000, 1000);

        }

        public void Timer_Elapsed(Object stateInfo)
        {
            downloadTXT();
        }

        public void TimerTest_Elapsed(Object stateInfo)
        {
            Console.WriteLine("Fuck  this shitelapsed!!!! " + i.ToString() + " times!!");
            i++;
        }

        public void downloadTXT()
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


    }
}
