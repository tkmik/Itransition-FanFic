using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.GenericRepository;
using DataAccess.Interfaces;
using DataAccess.Repositories;
using System;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;

        public UnitOfWork(
            AppDbContext context,
            ICapabilityRepository capabilityRepository,
            ICommentRepository commentRepository,
            IFanFicRepository fanFicRepository,
            ILikeRepository likeRepository,
            ITopicRepository topicRepository,
            IUserRepository userRepository,
            IUserCapabilityRepository userCapabilityRepository
            )
        {
            _context = context;
            Capability = capabilityRepository;
            Comment = commentRepository;
            FanFic = fanFicRepository;
            Like = likeRepository;
            Topic = topicRepository;
            User = userRepository;
            UserCapability = userCapabilityRepository;
        }

        public ICapabilityRepository Capability { get; set; }

        public ICommentRepository Comment { get; set; }

        public IFanFicRepository FanFic { get; set; }

        public ILikeRepository Like { get; set; }

        public ITopicRepository Topic { get; set; }

        public IUserRepository User { get; set; }

        public IUserCapabilityRepository UserCapability { get; set; }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
