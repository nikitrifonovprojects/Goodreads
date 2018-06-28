using Goodreads.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Goodreads.Data
{
    public class GoodreadsContext : IdentityDbContext<User>
    {
        public GoodreadsContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            //builder.Ignore<IdentityUserLogin<string>>();
            //builder.Ignore<IdentityUserRole<string>>();
            //builder.Ignore<IdentityUserClaim<string>>();
            //builder.Ignore<IdentityUserToken<string>>();
            //builder.Ignore<IdentityUser<string>>();
            //builder.Ignore<User>();
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Authors> Authors { get; set; }

        public DbSet<Award> Awards { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Genres> Genres { get; set; }

        public DbSet<Pictures> Pictures { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<IdentityUserRole<string>> Identity { get; set; }
    }
}
