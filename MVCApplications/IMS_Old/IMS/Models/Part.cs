using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IMS.Models
{
    public class Part
    {
        public int Id { get; set; }
        public string PartNumber { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string PicturePath { get; set; }
        public double Cost { get; set; }
        public bool IsActive { get; set; }

        //navigation Properties
        public PartType PartType { get; set; }
        public Category Category { get; set; }

        //Foreign Keys
        public int PartTypeId { get; set; }
        public int CategoryId { get; set; }
    }
}