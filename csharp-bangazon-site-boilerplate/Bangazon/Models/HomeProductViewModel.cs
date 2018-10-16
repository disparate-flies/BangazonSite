﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models
{
    public class HomeProductViewModel
    {
        //use a list instead of ICollection because this is in a viewModel and we may want to edit the list in the future
        [Display(Name="Product List")]
        public List<Product> RecentProducts { get; set; }
    }
}

