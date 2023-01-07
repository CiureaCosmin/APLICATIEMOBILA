using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using API.Models;

namespace API.Data
{
    public class APIContext : DbContext
    {
        public APIContext (DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public DbSet<API.Models.ShopList> ShopList { get; set; } = default!;

        public DbSet<API.Models.Category> Category { get; set; }

        public DbSet<API.Models.Services> Services { get; set; }

        public DbSet<API.Models.Salons> Salons { get; set; }

        public DbSet<API.Models.Appointments> Appointments { get; set; }

        public DbSet<API.Models.User> User { get; set; }
    }
}
