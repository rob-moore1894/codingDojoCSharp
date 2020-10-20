using Microsoft.EntityFrameworkCore;
namespace OneToMany.Models
{ 
    // the MyContext class representing a session with our MySQL 
    // database allowing us to query for or save data
    public class MyContext : DbContext 
    { 
        public MyContext(DbContextOptions options) : base(options) { }
        // the "Octopi" table name will come from the DbSet variable name
        public DbSet<Octopus> Octopi { get; set; }
        public DbSet<Tentacle> Tentacles { get; set; }
    }
}