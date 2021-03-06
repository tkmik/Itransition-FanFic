using AutoMapper;
using BusinessLogic.Interfaces;
using DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Services
{
    public class Service : IService
    {
        public Service(IUnitOfWork unit, IMapper map)
        {
            UnitOfWork = unit;
            Mapper = map;
        }
        public IUnitOfWork UnitOfWork { get; set; }
        public IMapper Mapper { get; set; }
    }
}
