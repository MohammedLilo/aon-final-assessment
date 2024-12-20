using aon_final_assessment.Models;
using Microsoft.EntityFrameworkCore;

namespace aon_final_assessment.Contexts
{
    public class MainDBContext : DbContext
    {

        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "products_db");
        }
    }
}
