using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employees.Models
{
    public class EmployesViewModel
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Number { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}