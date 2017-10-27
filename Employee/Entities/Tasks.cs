using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Entities
{
    public class Tasks:BaseEntity
    {

        public string Title { get; set; }
        public string Description { get; set; }
        public string DeadLine { get; set; }
        public int EmployeeId { get; set; }
        public List<Tasks> ListTasks { get; set; }
    }
}