using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.DTO
{
    public class LikeDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int FanFicId { get; set; }
        public FanFicDTO FanFic { get; set; }
    }
}
