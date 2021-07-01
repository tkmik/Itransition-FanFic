using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.Interfaces;
using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Services
{
    public class FanFicService : Service, IFanFicService
    {

        public FanFicService(AppDbContext context, IMapper map)
        {
            UnitOfWork = new UnitOfWork(context);
            Mapper = map;
        }

        public IEnumerable<FanFicDTO> GetFanFics()
        {
            return Mapper.Map<IEnumerable<FanFic>, IEnumerable<FanFicDTO>>(UnitOfWork.FanFic.GetAll());
        }
    }
}
