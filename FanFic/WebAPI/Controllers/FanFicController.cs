using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("fanfics")]
    [ApiController]
    public class FanFicController : Controller
    {
        private readonly IMapper _mapper;
        private readonly IFanFicService _fanFicService;

        public FanFicController(IMapper map, IFanFicService service)
        {
            _mapper = map;
            _fanFicService = service;
        }
        [HttpGet]
        public IEnumerable<FanFicViewModel> GetFanFic()
        {
            return _mapper.Map<IEnumerable<FanFicDTO>, IEnumerable<FanFicViewModel>>(_fanFicService.GetFanFics());
        }
    }
}
