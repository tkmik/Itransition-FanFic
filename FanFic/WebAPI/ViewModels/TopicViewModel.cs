using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<FanFicTopicViewModel> FanFics { get; set; }
    }
}
