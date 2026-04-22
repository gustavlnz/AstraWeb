using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Options;

namespace AstraWebMvc.Data
{
    public class AstraWebMvcContextFactory : IDesignTimeDbContextFactory<AstraWebMvcContext>
    {
        public AstraWebMvcContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AstraWebMvcContext>();
            optionsBuilder.UseMySql(
                "server=localhost;database=AstraWebMvc;user=root;password=astradev1505;",
                ServerVersion.AutoDetect("server=localhost;database=AstraWebMvc;user=root;password=astradev1505;")
                
            );

            return new AstraWebMvcContext(optionsBuilder.Options);
        }
    }
}
