using Microsoft.EntityFrameworkCore;
namespace ManyToMany.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Inventory> Stock {get; set;}

    }
}