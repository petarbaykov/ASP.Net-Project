using Employee.DataAccess;
using Employee.Entities;
using Employee.Models;
using Employee.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Employee.Controllers
{
    public class TasksController : Controller
    {
        TasksService service ;
        // GET: Tasks
        public TasksController()
        {
            service = new TasksService();
        }
        public ActionResult Index(int id)
        {
            TasksListViewModel model = new TasksListViewModel();
            
            List<Tasks> task = new List<Tasks>();


            task.AddRange(service.GetAll(tasks => tasks.EmployeeId == id));

            model.EmployeeId = id;
            foreach (var entity in task)
            {
                var taskModel = new TaskViewModel()
                {
                    Id = entity.Id,
                    Title = entity.Title,
                    DeadLine = entity.DeadLine,
                    Description = entity.Description,
                    CreatedAt = entity.CreatedAt,
                    UpdatetAt = entity.UpdatedAt,
                    EmployeeId = entity.EmployeeId
                };
                model.ListTasks.Add(taskModel);
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult Create(int id)
        {
            var model = new TaskViewModel()
            {
                EmployeeId = id
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(TaskViewModel model)
        {
            var entity = new Tasks();
            entity.Id = model.Id;
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.DeadLine = model.DeadLine;
            entity.EmployeeId = model.EmployeeId;
            service.Insert(entity);

            return RedirectToAction("Index/" + entity.EmployeeId);
        }
        [HttpGet]
        public ActionResult Update(int id)
        {
            Tasks entity = service.GetById(id);

            var model = new TaskViewModel()
            {
                Id = entity.Id,
                Title = entity.Title,
                DeadLine = entity.DeadLine,
                Description = entity.Description,
                CreatedAt = entity.CreatedAt,
                UpdatetAt = entity.UpdatedAt,
                EmployeeId = entity.EmployeeId
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Update(TaskViewModel model)
        {
            var entity = new Tasks();
            entity.Id = model.Id;
            entity.Title = model.Title;
            entity.DeadLine = model.DeadLine;
            entity.Description = model.Description;
            entity.UpdatedAt = model.UpdatetAt;
            entity.CreatedAt = model.CreatedAt;
            entity.EmployeeId = model.EmployeeId;

            service.Update(entity);
            return RedirectToAction("Index/" + entity.EmployeeId);
        }

        public ActionResult Delete(int id)
        {
            var entity = service.GetById(id);
            service.Delete(entity);
            return RedirectToAction("Index/" + entity.EmployeeId);
        }
    }
}