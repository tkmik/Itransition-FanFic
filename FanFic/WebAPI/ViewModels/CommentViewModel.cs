using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int FanFicId { get; set; }
        public FanFicViewModel FanFic { get; set; }
    }
}
