using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Like
    {
        public int Id { get; set; }

        public int FanFicId { get; set; }
        public FanFic FanFic { get; set; }
    }
}
