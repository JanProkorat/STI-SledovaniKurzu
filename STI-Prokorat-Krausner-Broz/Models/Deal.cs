using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace STIProkoratKrausnerBroz.Models
{
    public class Deal
    {
        public string Country { get; set; }
        public string CurrencyName { get; set; }
        public double BestSale { get; set; }
        public string BestSaleBank { get; set; }
        public double BestBuy { get; set; }
        public string BestBuyBank { get; set; }
        public string Recommendation { get; set; }

        public Deal(string country, string currencyName, double bestSale, string bestSaleBank, double bestBuy, string bestBuyBank, string recommendation)
        {
            Country = country;
            CurrencyName = currencyName;
            BestSale = bestSale;
            BestSaleBank = bestSaleBank;
            BestBuy = bestBuy;
            BestBuyBank = bestBuyBank;
            Recommendation = recommendation;
        }

        public Deal(){
            Country = "";
            CurrencyName = "";
            BestSale = double.MinValue;
            BestSaleBank = "";
            BestBuy = double.MaxValue;
            BestBuyBank = "";
            Recommendation = "";
        }
    }
}