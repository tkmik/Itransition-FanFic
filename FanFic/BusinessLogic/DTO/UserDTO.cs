using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.DTO
{
    public class UserDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        public ICollection<CommentDTO> Comments { get; set; }
        public ICollection<LikeDTO> Favorites { get; set; }
        public ICollection<UserCapabilityDTO> Capabilities { get; set; }

    }
}
