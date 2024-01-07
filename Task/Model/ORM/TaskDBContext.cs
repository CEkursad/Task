using Microsoft.EntityFrameworkCore;

namespace Task.Model.ORM
{
    public class TaskDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //connection string
            optionsBuilder.UseSqlServer("Server=KURSAD; Database=ProductDB; trusted_connection=true");
        }
        public DbSet<Product> Products { get; set; }
    }
}
