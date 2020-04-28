using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FW.Marketplace.ViewModel
{
    public class UserViewModel : BaseModelViewModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string ProfileImageUrl { get; set; }
    }
}
