using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Inventory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public double Quantity{ get; set; }

        //navigation Properties
        public Part Part { get; set; }

        //Foreign Keys
        public int PartId { get; set; }
    }
}