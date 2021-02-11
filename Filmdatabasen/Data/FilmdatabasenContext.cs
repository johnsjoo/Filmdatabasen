using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Filmdatabasen.Models;

namespace Filmdatabasen.Data
{
    public class FilmdatabasenContext : DbContext
    {
        public FilmdatabasenContext (DbContextOptions<FilmdatabasenContext> options)
            : base(options)
        {
        }

        public DbSet<Filmdatabasen.Models.Movie> Movie { get; set; }
    }
}
