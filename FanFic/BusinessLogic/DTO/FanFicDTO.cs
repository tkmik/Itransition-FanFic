using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Text;

namespace BusinessLogic.DTO
{
    public class FanFicDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public byte Rate { get; set; }
        public byte[] Image { get; set; }
        [Required]
        public int UserId { get; set; }
        public UserDTO Author { get; set; }

        public ICollection<CommentDTO> Comments { get; set; }
        public ICollection<LikeDTO> Likes { get; set; }
        public ICollection<FanFicTopicDTO> Topics { get; set; }

    }
}
