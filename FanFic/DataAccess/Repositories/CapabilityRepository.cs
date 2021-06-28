using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.GenericRepository;
using DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DataAccess.Repositories
{
    public class CapabilityRepository : GenericRepository<Capability>, ICapabilityRepository
    {
        public CapabilityRepository(AppDbContext context) : base(context)
        {   }
    }
}
