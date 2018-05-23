using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Goodreads.Data.Models
{
    public class Books
    {
        [Range(1, int.MaxValue)]
        public int Id { get; set; }

        public string BookName { get; set; }

        public string BookSeries { get; set; }

        public string Author { get; set; }

        public string BookCover { get; set; }


    }
}
