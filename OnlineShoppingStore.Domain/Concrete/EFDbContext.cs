using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineShoppingStore.Domain.Entities;
using System.Data.Entity;

namespace OnlineShoppingStore.Domain.Concrete
{
   public class EFDbContext : DbContext
    {
        public DbSet <Product> Products { get; set;  }
        public DbSet<User> Users { get; set; }
    }
}
