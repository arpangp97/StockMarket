using System;
using System.Collections.Generic;

namespace EPPlusCore.Models
{
    public partial class StockPrice
    {
        public int RowId { get; set; }
        public int? CompanyCode { get; set; }
        public string StockExchange { get; set; }
        public string CurrentPrice { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
    }
}
