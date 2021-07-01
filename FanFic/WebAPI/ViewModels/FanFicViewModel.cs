using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace WebAPI.ViewModels
{
    public class FanFicViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public byte Rate { get; set; }
        public byte[] Image { get; set; }

        public int UserId { get; set; }
        public UserViewModel Author { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
        public ICollection<LikeViewModel> Likes { get; set; }
        public ICollection<FanFicTopicViewModel> Topics { get; set; }

    }
}
