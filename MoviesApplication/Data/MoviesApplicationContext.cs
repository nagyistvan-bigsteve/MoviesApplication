using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MoviesApplication.Models;

namespace MoviesApplication.Data
{
    public class MoviesApplicationContext : DbContext
    {
        public MoviesApplicationContext (DbContextOptions<MoviesApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<MoviesApplication.Models.Movie> Movie { get; set; }
    }
}
