using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Filmdatabasen.Data;
using Filmdatabasen.Models;

namespace Filmdatabasen.Pages.Images
{
    public class IndexModel : PageModel
    {
        private readonly Filmdatabasen.Data.FilmdatabasenContext _context;

        public IndexModel(Filmdatabasen.Data.FilmdatabasenContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
