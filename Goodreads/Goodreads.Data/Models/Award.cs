using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Goodreads.Data.Models
{
    public class Award
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Book> WinnerBooks { get; set; }
    }
}
