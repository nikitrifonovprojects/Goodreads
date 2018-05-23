using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Goodreads.Data.Models
{
    public class User
    {
        [Range(1,-int.MaxValue)]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string ZipCode { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public string Website { get; set; }

        public string Interests { get; set; }

        public string FavoriteBooks { get; set; }

        public string About { get; set; }

        public string PictureFile { get; set; }

        public List<Genres> Genres { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Password { get; set; }


    }
}
