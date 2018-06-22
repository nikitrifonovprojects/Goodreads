using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Goodreads.Data.Models
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public List<Authors> Authors { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Published { get; set; }

        public string OriginalTitle { get; set; }

        [Required]
        public string ISBN { get; set; }

        public string EditionLanguage { get; set; }

        public string LiteraryAwards { get; set; }

        public List<Book> OtherEditions { get; set; }

        public string Series { get; set; }

        public List<Character> Charcters { get; set; }

        public byte[] Cover { get; set; }

        public Rating Rating { get; set; }
    }
}
