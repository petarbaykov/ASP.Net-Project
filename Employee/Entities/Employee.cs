using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Entities
{
    public class Employe:BaseEntity
    {

        public string FName { get; set; }
        public string LName { get; set; }
        public int number { get; set; }

        public virtual List<Employe> Employees { get; set; }
    }
}