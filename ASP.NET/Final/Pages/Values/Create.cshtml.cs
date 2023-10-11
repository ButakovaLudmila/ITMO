using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Final.Data;
using Final.Models;
using Microsoft.EntityFrameworkCore;

namespace Final.Pages.Values
{
    public class CreateModel : PageModel
    {
        private readonly Final.Data.FinalContext _context;

        public CreateModel(Final.Data.FinalContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {           
            return Page();
        }

        [BindProperty]
        public Value Value { get; set; } = default!;
        public Theme Theme { get; set; } = default!;
        public IList<Student> Student { get; set; } = default!;

 
        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Value == null || Value == null)
            {
                return Page();
            }

            if (!ModelState.IsValid || _context.Student == null || Student == null)
            {
                return Page();
            }

            _context.Value.Add(Value);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
