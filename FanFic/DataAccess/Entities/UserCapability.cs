using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class UserCapability
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CapabilityId { get; set; }
        public Capability Capability { get; set; }
    }
}
