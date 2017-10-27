using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Employees.Models;
using Employees.Services;
using Employee.Entities;

namespace Employees.Controllers
{
    public class EmployeesController : Controller
    {
        private EmployeesServices service ;
        // GET: Employees
        public EmployeesController()
        {
            service = new EmployeesServices();
        }
        public ActionResult Index()
        {
            EmployeesListViewModel model = new EmployeesListViewModel();

            List<Employe> employees = new List<Employe>();

            employees.AddRange(service.GetAll());

            foreach(var entity in employees)
            {
                var employeesModel = new EmployesViewModel()
                {
                    Id = entity.Id,
                    FName = entity.FName,
                    LName = entity.LName,
                    CreatedAt = entity.CreatedAt,
                    UpdatedAt = entity.UpdatedAt
                };

                model.EmployeesList.Add(employeesModel);

            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EmployesViewModel model)
        {
            var entity = new Employe();
            entity.FName = model.FName;
            entity.LName = model.LName;
            entity.number = model.Number;
            service.Insert(entity);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            Employe entity = service.GetById(id);
            var model = new EmployesViewModel()
            {
                Id = entity.Id,
                FName = entity.FName,
                LName = entity.LName,
                Number = entity.number,
                CreatedAt = entity.CreatedAt,
                UpdatedAt = entity.UpdatedAt
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult Update(EmployesViewModel model)
        {
            var entity = new Employe();
            entity.Id = model.Id;
            entity.FName = model.FName;
            entity.LName = model.LName;
            entity.CreatedAt = model.CreatedAt;
            entity.UpdatedAt = model.UpdatedAt;

            service.Update(entity);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var entity = service.GetById(id);
            service.Delete(entity);
            return RedirectToAction("Index");
        }
    }
}