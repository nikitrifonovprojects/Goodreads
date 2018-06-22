using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Goodreads.Data.Models
{
    public class Authors
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Born { get; set; }

        public string Website { get; set; }

        public string Twitter { get; set; }

        public List<Genres> Genre { get; set; }

        public string Influences { get; set; }

        [Required]
        public DateTime MemberSince { get; set; }

        public string AuthorUrl { get; set; }

        public string AuthorData { get; set; }

        [Required]
        public User User { get; set; }
    }
}
