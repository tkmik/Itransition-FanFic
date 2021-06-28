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
        private DbSet<TEntity> _entity;
        public GenericRepository(AppDbContext context)
        {
            _dbContext = context;
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return Entity;
        }
        public virtual TEntity Get(object id)
        {
            return Entity.Find(id);
        }
        public virtual void Add(TEntity item)
        {
            Entity.Add(item);
        }        
        public virtual void Update(TEntity item)
        {
            Entity.Attach(item);
            _dbContext.Entry(item).State = EntityState.Modified;
        }
        public virtual void Delete(object id)
        {
            TEntity entity = Entity.Find(id);
            Delete(entity);
        }   
        public virtual void Delete(TEntity entity)
        {
            if (_dbContext.Entry(entity).State == EntityState.Detached)
            {
                Entity.Attach(entity);
            }
            Entity.Remove(entity);
        }
        protected virtual DbSet<TEntity> Entity
        {
            get
            {
                if (_entity is null)
                {
                    _entity = _dbContext.Set<TEntity>();
                }
                return _entity;
            }
        }
    }
}
