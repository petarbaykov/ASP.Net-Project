using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee.Entities;
namespace Employee.Models
{
    public class TasksListViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int EmployeeId { get; set; }

        public List<TaskViewModel> ListTasks { get; private set; }

        public TasksListViewModel()
        {
            ListTasks = new List<TaskViewModel>();
        }
    }
}