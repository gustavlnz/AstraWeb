using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AstraWebMvc.Models;

namespace AstraWebMvc.Data
{
    public class AstraWebMvcContext : DbContext
    {
        public AstraWebMvcContext (DbContextOptions<AstraWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<AstraWebMvc.Models.Department> Department { get; set; } = default!;
    }
}
