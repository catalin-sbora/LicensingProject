﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LicensingProject.DataAccess.Models
{
    public class Product: BaseEntity
    {
        public string? Name { get; set; }
        public string? ShortName { get; set; }
    }
}
