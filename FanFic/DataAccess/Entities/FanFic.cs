using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DataAccess.Entities
{
    public class FanFic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public byte Rate { get; set; }
        public byte[] Image { get; set; }

        public int UserId { get; set; }
        public User Author { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<FanFicTopic> Topics { get; set; }

    }
}
