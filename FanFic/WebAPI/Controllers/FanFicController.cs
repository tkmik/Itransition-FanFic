using DataAccess.EF;
using DataAccess.Entities;
using DataAccess.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FanFicController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public FanFicController(IUnitOfWork unit)
        {
            _unitOfWork = unit;
        }
        [HttpGet]
        public IEnumerable<FanFic> GetFanFic()
        {
            return _unitOfWork.FanFic.GetAll();
        }
    }
}
