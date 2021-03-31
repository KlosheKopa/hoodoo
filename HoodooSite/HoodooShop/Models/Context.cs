using HoodooPrototype.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HillsideShop.Models
{
    public class Context : IdentityDbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Product> Products { get; set; }

        public DbSet<AppUser> User { get; set; }

        public DbSet<RentalForm> Forms { get; set; }

        public DbSet<OrderLineItem> Items { get; set; }

        public DbSet<FeaturedProduct> Featured { get; set; }
    }
}
