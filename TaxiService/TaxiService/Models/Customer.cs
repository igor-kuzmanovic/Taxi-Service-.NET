﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaxiService.Models
{
    public class Customer : ApplicationUser
    {
        public UserRole Role { get; set; } = UserRole.Customer;
    }
}