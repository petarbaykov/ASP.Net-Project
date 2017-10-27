using Employee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employee.Models
{
    public class TaskViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatetAt { get; set; }
        public string DeadLine { get; set; }
        public int EmployeeId { get; set; }
    }
}