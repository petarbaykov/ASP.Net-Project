using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Employee.Entities;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Employee.DataAccess
{
    public class BaseRepository<T> where T:BaseEntity
    {
        private DbContext context;
        private DbSet<T> dbSet;

        public BaseRepository()
        {
            context = new EmployeesContext();
            dbSet = context.Set<T>();
        }

        public void Insert(T entity)
        {
            context.Entry(entity).State = EntityState.Added;
            context.SaveChanges();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return dbSet.Where(filter).ToList();
        }

        public List<T> GetAll()
        {
            return dbSet.ToList();
        }

        public T GetById(int id)
        {
            return dbSet.Find(id);
        }
        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
    }
}