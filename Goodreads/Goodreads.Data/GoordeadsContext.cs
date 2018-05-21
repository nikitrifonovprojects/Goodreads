using Microsoft.EntityFrameworkCore;

namespace Goodreads.Data
{
    public class GoordeadsContext : DbContext
    {
        public GoordeadsContext(DbContextOptions options) 
            : base(options)
        {
        }
    }
}
