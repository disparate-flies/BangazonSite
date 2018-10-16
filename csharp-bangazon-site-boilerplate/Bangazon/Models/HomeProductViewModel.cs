using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bangazon.Models
{
    public class HomeProductViewModel
    {
        public int ProductId { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
