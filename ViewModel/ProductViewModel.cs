using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FW.Marketplace.ViewModel
{
    public class ProductViewModel : BaseModelViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string ShareUrl { get; set; }
        public string ImageUrl { get; set; }
        public string ContactInfo { get; set; }
        public DateTime? ExpiredIn { get; set; }
        public UserViewModel Owner { get; set; }
    }
}
