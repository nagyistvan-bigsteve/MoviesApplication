using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesApplication.Models
{
    public class Movie
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Producer { get; set; }

    }
}
