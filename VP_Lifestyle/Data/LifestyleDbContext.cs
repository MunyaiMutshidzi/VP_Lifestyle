using Microsoft.EntityFrameworkCore;
using VP_Lifestyle.Models;

namespace VP_Lifestyle.Data
{
    public class LifestyleDbContext:DbContext
    {
        public LifestyleDbContext(DbContextOptions<LifestyleDbContext> options) 
            : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }    
    }
}
