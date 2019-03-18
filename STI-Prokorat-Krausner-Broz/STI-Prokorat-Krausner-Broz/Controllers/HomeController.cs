using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using STI_Prokorat_Krausner_Broz.Models;
using STIProkoratKrausnerBroz.Models;

namespace STI_Prokorat_Krausner_Broz.Controllers
{
    public class HomeController : Controller
    { 
    public IActionResult Index()
        {
            ToolsClass t = new ToolsClass();

            String[] bankCodes= new String[5];
            bankCodes[0] = "CNB";
            bankCodes[1] = "CSOB";
            bankCodes[2] = "CS";
            bankCodes[3] = "RB";
            bankCodes[4] = "KB";
            int bankCount = 0;
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


    }
}
