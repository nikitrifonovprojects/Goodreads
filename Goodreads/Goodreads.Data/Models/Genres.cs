using System.ComponentModel.DataAnnotations;

namespace Goodreads.Data.Models
{
    public class Genres
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
