using System;

namespace FW.Marketplace.Model
{
    public class Product
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string ShareUrl { get; set; }
        public string ImageUrl { get; set; }
        public string ContactInfo { get; set; }
        public DateTime? ExpiredIn { get; set; }
        public User Owner { get; set; }
    }
}
