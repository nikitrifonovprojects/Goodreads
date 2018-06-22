﻿using Goodreads.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace Goodreads.Data
{
    public class GoodreadsContext : DbContext
    {
        public GoodreadsContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Authors> Authors { get; set; }

        public DbSet<Award> Awards { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Character> Characters { get; set; }

        public DbSet<Genres> Genres { get; set; }

        public DbSet<Pictures> Pictures { get; set; }

        public DbSet<Rating> Ratings { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
