using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab21.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [MaxLength(50, ErrorMessage = "Title cannot be longer than 50 characters.")]
        public string Title { get; set; }

        public string Genre { get; set; }

        [Range(1880, 2021, ErrorMessage = "Year cannot be before 1880 or after 2021.")]
        public int Year { get; set; }

        public string Actors { get; set; }

        public string Directors { get; set; }
    }
}
