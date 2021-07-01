using DataAccess.Entities;
using DataAccess.GenericRepository;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICapabilityRepository Capability { get; set; }
        ICommentRepository Comment { get; set; }
        IFanFicRepository FanFic { get; set; }
        ILikeRepository Like { get; set; }
        ITopicRepository Topic { get; set; }
        IUserRepository User { get; set; }
        IUserCapabilityRepository UserCapability { get; }
        void Save();
    }
}
