using System.Collections.Generic;
using Store.Models;

namespace Store.ViewModels
{
    public class CreatePhoneViewModel
    {
        public Phone Phone { get; set; }
        public List<Brand> Brands { get; set; }

    }
}