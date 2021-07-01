using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.DTO
{
    public class UserCapabilityDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public UserDTO User { get; set; }
        [Required]
        public int CapabilityId { get; set; }
        public CapabilityDTO Capability { get; set; }
    }
}
