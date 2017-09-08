using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Price
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double MarkUp { get; set; }

        //navigation Properties
        public Part Part
        {
            get
            {
                return new Part
                {
                    //Get Part by PartId (Part with Id==200)
                };
            }
        }

        //Foreign Keys
        public int PartId { get; set; }//==200
    }
}