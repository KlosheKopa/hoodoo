using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using HoodooPrototype.Models;

namespace HoodooPrototype.Data
{
    public class HoodooPrototypeContext : DbContext
    {
        public HoodooPrototypeContext (DbContextOptions<HoodooPrototypeContext> options)
            : base(options)
        {
        }

        public DbSet<HoodooPrototype.Models.AppUser> AppUser { get; set; }

        public DbSet<HoodooPrototype.Models.Orders> Orders { get; set; }

        public DbSet<HoodooPrototype.Models.Product> Product { get; set; }
    }
}
