using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee.DataAccess;
using Employee.Entities;

namespace Employees.Services
{
    public class EmployeesServices
    {
        private EmployeesRepository repository;

        public EmployeesServices()
        {
            repository = new EmployeesRepository();
        }

        public void Insert(Employe entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            repository.Insert(entity);
        }

        public List<Employe> GetAll()
        {
            return repository.GetAll();
        }

        public Employe GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(Employe entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            repository.Update(entity);
        }
        public void Delete(Employe entity)
        {
            repository.Delete(entity);
        }
    }
}