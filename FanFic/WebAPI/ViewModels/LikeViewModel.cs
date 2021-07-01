using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels
{
    public class LikeViewModel
    {
        public int Id { get; set; }

        public int FanFicId { get; set; }
        public FanFicViewModel FanFic { get; set; }
    }
}
