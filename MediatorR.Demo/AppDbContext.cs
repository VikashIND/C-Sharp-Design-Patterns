using Microsoft.EntityFrameworkCore;

namespace MediatorR.Demo
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Contact> Contacts { get; set; } = null!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact() { Id = 1, FirstName = "Steve", LastName = "Jobs"},
                new Contact() { Id = 2, FirstName = "Bill", LastName = "Gates"},
                new Contact() { Id = 3, FirstName = "Satya", LastName = "Nadela" }
                );           
        }
    
    }
}
