using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3.Models;

namespace Assignment3.Data
{
    public class Assignment3Context : DbContext
    {
        public Assignment3Context (DbContextOptions<Assignment3Context> options)
            : base(options)
        {
        }

        public DbSet<Assignment3.Models.Product> Product { get; set; } = default!;
        public DbSet<Assignment3.Models.Cart> Cart { get; set; } = default!;
        public DbSet<Assignment3.Models.User> User { get; set; } = default!;
        public DbSet<Assignment3.Models.Comment> Comment { get; set; } = default!;
        public DbSet<Assignment3.Models.Order> Order { get; set; } = default!;
    }
}
