using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.GenericRepository;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    class UserCapabilityRepository : GenericRepository<UserCapability>, IUserCapabilityRepository
    {
        public UserCapabilityRepository(AppDbContext context) : base(context)
        {   }
    }
}
