using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels
{
    public class UserCapabilityViewModel
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public UserViewModel User { get; set; }

        public int CapabilityId { get; set; }
        public CapabilityViewModel Capability { get; set; }
    }
}
