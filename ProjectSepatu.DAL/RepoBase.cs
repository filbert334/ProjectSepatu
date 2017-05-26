using Microsoft.EntityFrameworkCore;
using ProjectSepatu.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectSepatu.DAL
{
    public class RepoBase<T> : IRepository<T> where T : ProductParent
    {
        
        protected AppDbContext context;
        protected DbSet<T> dbSet;

        public RepoBase(AppDbContext contexts)
        {
            context = contexts;
            dbSet = context.Set<T>();
        }
        public void Delete(long id)
        {
            var entity = GetById(id);
            dbSet.Remove(entity);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public List<T> GetAll()
        {
            return dbSet.OrderBy(e => e.Id).ToListAsync().Result;
        }

        public T GetById(long id)
        {
            return dbSet.Find(id);
        }

        public void Save(T entity)
        {
            if (entity.Id == 0)
                dbSet.Add(entity);
            else
            {
                context.Entry(entity).State = EntityState.Modified;
            }
            context.SaveChanges();
        }
    }
}
