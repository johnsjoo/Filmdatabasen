using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Filmdatabasen.Pages
{
    public class IndexModel : PageModel
    {
        private readonly Data.FilmdatabasenContext _context;

        public IndexModel(Data.FilmdatabasenContext context)
        {
            _context = context;
        }

        [BindProperty(SupportsGet = true)]
        public string Category { get; set; }

        public IEnumerable<Models.Movie> AllMovies { get; set; }

        public IEnumerable<Models.Movie> Movies { get; set; }

        public void OnGet()
        {
            AllMovies = _context.Movie;
            if (string.IsNullOrWhiteSpace(Category))
            {
                Movies = AllMovies;
            }
            else
            {
                Movies = _context.Movie.Where(Movie => Movie.MovieCategory == Category);
            }
        }
    }
}
