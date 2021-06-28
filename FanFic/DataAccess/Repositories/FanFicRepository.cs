using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.GenericRepository;
using DataAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Repositories
{
    public class FanFicRepository : GenericRepository<FanFic>, IFanFicRepository
    {
        public FanFicRepository(AppDbContext context) : base(context)
        {   }
    }
}
