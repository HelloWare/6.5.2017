using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using IMS.Models;

namespace IMS.Repositories
{
    public class PartTypeRepo
    {
        public void Insert(PartType partType)
        {
            //Insert type to db
        }

        public IEnumerable<PartType> SelectAll()
        {
            IEnumerable<PartType> partTypes = new List<PartType>();
            //Get all types from database
            return partTypes;
        }

        public PartType Select(int id)
        {
            PartType partType = new PartType();
            //Get PartType by Id
            return partType;
        }

        public void Update(PartType partType)
        {
            //udpate partType to db
        }

        public void Delete(int id)
        {
            //Delete PartType by Id
        }
    }
}