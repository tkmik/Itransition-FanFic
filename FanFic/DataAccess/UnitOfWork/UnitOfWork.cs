using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.GenericRepository;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }

        public IGenericRepository<Capability> Capability => new CapabilityRepository(_context);

        public IGenericRepository<Comment> Comment => new CommentRepository(_context);

        public IGenericRepository<FanFic> FanFic => new FanFicRepository(_context);

        public IGenericRepository<Like> Like => new LikeRepository(_context);

        public IGenericRepository<Topic> Topic => new TopicRepository(_context);

        public IGenericRepository<User> User => new UserRepository(_context);

        public IGenericRepository<UserCapability> UserCapability => new UserCapabilityRepository(_context);

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
