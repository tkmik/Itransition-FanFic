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

        private IGenericRepository<Capability> _capabilityRepository;
        private IGenericRepository<Comment> _commentRepository;
        private IGenericRepository<FanFic> _fanFicRepository;
        private IGenericRepository<Like> _likeRepository;
        private IGenericRepository<Topic> _topicRepository;
        private IGenericRepository<User> _userRepository;
        private IGenericRepository<UserCapability> _userCapabilityRepository;
        public IGenericRepository<Capability> Capability 
        {
            get
            {
                if (_capabilityRepository is null)
                {
                    _capabilityRepository = new CapabilityRepository(_context);
                }
                return _capabilityRepository;
            }
        }

        public IGenericRepository<Comment> Comment
        {
            get
            {
                if (_commentRepository is null)
                {
                    _commentRepository = new CommentRepository(_context);
                }
                return _commentRepository;
            }
        }

        public IGenericRepository<FanFic> FanFic
        {
            get
            {
                if (_fanFicRepository is null)
                {
                    _fanFicRepository = new FanFicRepository(_context);
                }
                return _fanFicRepository;
            }
        }

        public IGenericRepository<Like> Like
        {
            get
            {
                if (_likeRepository is null)
                {
                    _likeRepository = new LikeRepository(_context);
                }
                return _likeRepository;
            }
        }

        public IGenericRepository<Topic> Topic
        {
            get
            {
                if (_topicRepository is null)
                {
                    _topicRepository = new TopicRepository(_context);
                }
                return _topicRepository;
            }
        }
        public IGenericRepository<User> User
        {
            get
            {
                if (_userRepository is null)
                {
                    _userRepository = new UserRepository(_context);
                }
                return _userRepository;
            }
        }

        public IGenericRepository<UserCapability> UserCapability
        {
            get
            {
                if (_userCapabilityRepository is null)
                {
                    _userCapabilityRepository = new UserCapabilityRepository(_context);
                }
                return _userCapabilityRepository;
            }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
