using BlogSite.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlogSite.Data
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category()
                {
                    CategoryID = 1,
                    CategoryName = "Default",
                    IsActive = true
                }
                );
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    UserID= 1,
                    FirstName = "Admin",
                    LastName = "User",
                    IsActive = true,
                    IsAdmin = true,
                    Email = "admin@blogger.com",
                    Password = "12345",
                    UserName = "admin"
                }
                );
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-LKI90HI\SQLEXPRESS; database=BlogSite; Trusted_Connection=true; Encrypt=False; MultipleActiveResultSets=true");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
