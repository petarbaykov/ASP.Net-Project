using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Employee.Entities;

namespace Employee.DataAccess
{
    public class EmployeesContext:DbContext
    {
       public DbSet<Employe> Employees { get; set; }
        public DbSet<Tasks> Tasks { get; set; }
        public EmployeesContext()
            :base("EmployeesDb")
        {

        }
    }
}