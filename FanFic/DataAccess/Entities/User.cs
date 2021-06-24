using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Favorites { get; set; }
        public ICollection<UserCapability> Capabilities { get; set; }

    }
}
