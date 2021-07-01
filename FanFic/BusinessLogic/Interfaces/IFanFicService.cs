using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IFanFicService : IService
    {
        IEnumerable<FanFicDTO> GetFanFics();
    }
}
