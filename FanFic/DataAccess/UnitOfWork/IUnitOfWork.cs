using DataAccess.Entities;
using DataAccess.GenericRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        IGenericRepository<Capability> Capability { get; }
        IGenericRepository<Comment> Comment { get; }
        IGenericRepository<FanFic> FanFic { get; }
        IGenericRepository<Like> Like { get; }
        IGenericRepository<Topic> Topic { get; }
        IGenericRepository<User> User { get; }
        IGenericRepository<UserCapability> UserCapability { get; }
        void Save();
    }
}
