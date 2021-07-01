using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels
{
    public class FanFicTopicViewModel
    {
        public int Id { get; set; }

        public int FanFicId { get; set; }
        public FanFicViewModel FanFic { get; set; }

        public int TopicId { get; set; }
        public TopicViewModel Topic { get; set; }
    }
}
