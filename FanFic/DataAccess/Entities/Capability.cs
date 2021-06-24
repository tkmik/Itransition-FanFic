using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class Capability
    {
        public int Id { get; set; }
        public EnumCapability NameCapability { get; set; }

        public ICollection<UserCapability> Capabilities { get; set; }
    }
}
