using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class ProductInfoViewModel
    {
        public Part Part { get; set; }
        public List<Price> Prices { get; set; }
        public List<Inventory> Inventories { get; set; }
    }
}