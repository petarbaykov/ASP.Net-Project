using Employee.DataAccess;
using Employee.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Employee.Services
{
    public class TasksService
    {
        private TasksRepository repository;

        public TasksService()
        {
            repository = new TasksRepository();
        }

        public void Insert(Tasks entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;

            repository.Insert(entity);
        }
        public List<Tasks> GetAll(Expression<Func<Tasks, bool>> filter)
        {
            return repository.GetAll(filter);
        }

        public List<Tasks> GetAll()
        {
            return repository.GetAll();
        }
        public Tasks GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Update(Tasks entity)
        {
            entity.CreatedAt = DateTime.Now;
            entity.UpdatedAt = DateTime.Now;
            repository.Update(entity);
        }
        public void Delete(Tasks entity)
        {
            repository.Delete(entity);
        }
    }
}