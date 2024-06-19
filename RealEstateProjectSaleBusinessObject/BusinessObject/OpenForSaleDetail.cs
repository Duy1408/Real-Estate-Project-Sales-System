﻿using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateProjectSaleBusinessObject.BusinessObject
{
    public class OpenForSaleDetail
    {
        public int Floor { get; set; }
        public string TypeRoom { get; set; }

        public double Price { get; set; }

    }
}