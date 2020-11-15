using Microsoft.EntityFrameworkCore;

namespace LearnASPNETCoreMVCWithRealApps.Models
{
    public class DataContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    var builder = new ConfigurationBuilder()
        //                             .SetBasePath(Directory.GetCurrentDirectory())
        //                             .AddJsonFile("appsettings.json");

        //    var configuration = builder.Build();
        //    optionsBuilder.UseSqlServer(configuration["ConnectionStrings:DefaultConnection"]);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-SQQADL8\\SQLEXPRESS;Initial Catalog=LearnASPNETMVCWithRealApps;Integrated Security=True");
        }

        public DbSet<Product> Product { get; set; }
    }
}
