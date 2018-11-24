using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplicationFAIC.Models;

namespace WebApplicationFAIC.Models
{
    public class WebApplicationFAICContext : DbContext
    {
        public WebApplicationFAICContext (DbContextOptions<WebApplicationFAICContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplicationFAIC.Models.Category> Category { get; set; }

        public DbSet<WebApplicationFAIC.Models.Product> Product { get; set; }
    }
}
