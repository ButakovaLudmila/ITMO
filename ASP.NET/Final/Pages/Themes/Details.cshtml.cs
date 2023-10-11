using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Data;
using Final.Models;

namespace Final.Pages.Themes
{
    public class DetailsModel : PageModel
    {
        private readonly Final.Data.FinalContext _context;

        public DetailsModel(Final.Data.FinalContext context)
        {
            _context = context;
        }

      public Theme Theme { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Theme == null)
            {
                return NotFound();
            }

            var theme = await _context.Theme.FirstOrDefaultAsync(m => m.ID == id);
            if (theme == null)
            {
                return NotFound();
            }
            else 
            {
                Theme = theme;
            }
            return Page();
        }
    }
}
