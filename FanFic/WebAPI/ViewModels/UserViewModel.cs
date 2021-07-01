using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public ICollection<CommentViewModel> Comments { get; set; }
        public ICollection<LikeViewModel> Favorites { get; set; }
        public ICollection<UserCapabilityViewModel> Capabilities { get; set; }

    }
}
