using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels
{
    public class CapabilityViewModel
    {
        public int Id { get; set; }
        public EnumCapabilityViewModel NameCapability { get; set; }

        public ICollection<UserCapabilityViewModel> Capabilities { get; set; }
    }
}
