using DataAccess.EF;
using DataAccess.GenericRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.GenericRepository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly AppDbContext _dbContext;

        private DbSet<TEntity> entity;

        public GenericRepository(AppDbContext context)
        {
            _dbContext = context;
        }
        protected virtual DbSet<TEntity> Table
        {
            get
            {
                if (entity is null)
                {
                    entity = _dbContext.Set<TEntity>();
                }
                return entity;
            }
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Table;
        }

        public virtual TEntity Get(object id)
        {
            return Table.Find(id);
        }

        public virtual void Add(TEntity item)
        {
            Table.Add(item);
        }        

        public virtual void Update(TEntity item)
        {
            Table.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }

        public virtual void Delete(object id)
        {
            TEntity entity = Table.Find(id);
            Delete(entity);
        }   

        public virtual void Delete(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                Table.Attach(entity);
            }
            Table.Remove(entity);
        }        
    }
}
