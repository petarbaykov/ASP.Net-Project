using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Employees.Models
{
    public class EmployeesListViewModel
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public List<EmployesViewModel> EmployeesList { get; private set; }

        public EmployeesListViewModel()
        {
            EmployeesList = new List<EmployesViewModel>();
        }
    }
}