using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BusinessLogic.DTO
{
    public class CapabilityDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public EnumCapabilityDTO NameCapability { get; set; }

        public ICollection<UserCapabilityDTO> Capabilities { get; set; }
    }
}
