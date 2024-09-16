using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace BlazorApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<AppUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

                       
            builder.Entity<IdentityRole>(b =>
            {
                b.HasData(
                    new IdentityRole("Administrator"),
                    new IdentityRole("Supervisor")
                    );
            });

            builder.Entity<Student>(b => 
            {
                b.HasKey(p => p.StudentNo);
                b.Property(p=>p.StudentNo)
                    .HasMaxLength(32);
            });

        }
    }
}
