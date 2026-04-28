using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AstraWebMvc.Models;
using AstraWebMvc.Models.ViewModels;

namespace AstraWebMvc.Data
{
    public class AstraWebMvcContext : DbContext
    {
        public AstraWebMvcContext (DbContextOptions<AstraWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }

    }
}
