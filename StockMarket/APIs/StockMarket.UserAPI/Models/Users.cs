﻿using System;
using System.Collections.Generic;

namespace StockMarket.UserAPI.Models
{
    public partial class Users
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }
        public string Email { get; set; }
        public string MobileNo { get; set; }
        public string Confirmed { get; set; }
    }
}
