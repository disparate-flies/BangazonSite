using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bangazon.Models
{
    public class BangazonContext : DbContext
    {
        public BangazonContext (DbContextOptions<BangazonContext> options)
            : base(options)
        {
        }

        public DbSet<Bangazon.Models.ProductType> ProductType { get; set; }
    }
}
