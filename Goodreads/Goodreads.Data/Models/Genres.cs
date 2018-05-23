using System.ComponentModel.DataAnnotations;

namespace Goodreads.Data.Models
{
    public class Genres
    {
        [Range(1, -int.MaxValue)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
