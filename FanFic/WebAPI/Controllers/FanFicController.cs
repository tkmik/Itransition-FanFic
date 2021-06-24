using DataAccess.EF;
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
        private readonly AppDbContext _dbContext;

        public FanFicController(AppDbContext context)
        {
            _dbContext = context;
        }
        [HttpGet]
        public IActionResult GetFanFic()
        {
            return new JsonResult(_dbContext.FanFic.ToList());
        }
    }
}
