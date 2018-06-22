using System.ComponentModel.DataAnnotations;

namespace Goodreads.Data.Models
{
    public class Pictures
    {
        public int Id { get; set; }

        [Required]
        public byte[] PictureFile { get; set; }
    }
}
