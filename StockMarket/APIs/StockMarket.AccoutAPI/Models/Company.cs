using System;
using System.Collections.Generic;

namespace StockMarket.AccoutAPI.Models
{
    public partial class Company
    {
        public string Companyname { get; set; }
        public int? Turnover { get; set; }
        public string Ceo { get; set; }
        public string Stackexchage { get; set; }
    }
}
