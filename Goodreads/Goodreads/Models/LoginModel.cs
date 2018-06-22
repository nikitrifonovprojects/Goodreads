﻿using System.ComponentModel.DataAnnotations;

namespace Goodreads.Models
{
    public class LoginModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public bool RemmemberMe { get; set; }
    }
}
