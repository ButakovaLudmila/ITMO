using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Final.Data;
using Final.Models;

namespace Final.Pages.Values
{
    public class DetailsModel : PageModel
    {
        private readonly Final.Data.FinalContext _context;

        public DetailsModel(Final.Data.FinalContext context)
        {
            _context = context;
        }

      public Value Value { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Value == null)
            {
                return NotFound();
            }

            var value = await _context.Value.FirstOrDefaultAsync(m => m.ID == id);
            if (value == null)
            {
                return NotFound();
            }
            else 
            {
                Value = value;
            }
            return Page();
        }
    }
}
