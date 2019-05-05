using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1CSharp
{
    public class Movie
    {
        public int Id { get; set; }
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Title must have between 2 and 100 characters!")]
        public string Title { get; set; }
        public int Runtime { get; set; }
        public double Rating { get; set; }
        public string Storyline { get; set; }
    }
}
