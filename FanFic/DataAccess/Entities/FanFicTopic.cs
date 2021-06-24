using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class FanFicTopic
    {
        public int Id { get; set; }

        public int FanFicId { get; set; }
        public FanFic FanFic { get; set; }

        public int TopicId { get; set; }
        public Topic Topic { get; set; }
    }
}
