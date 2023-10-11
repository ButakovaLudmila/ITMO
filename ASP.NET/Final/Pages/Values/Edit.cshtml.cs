using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Final.Data;
using Final.Models;

namespace Final.Pages.Values
{
    public class EditModel : PageModel
    {
        private readonly Final.Data.FinalContext _context;

        public EditModel(Final.Data.FinalContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Value Value { get; set; } = default!;
        public Student Student { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Value == null)
            {
                return NotFound();
            }
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var value =  await _context.Value.FirstOrDefaultAsync(m => m.ID == id);
            if (value == null)
            {
                return NotFound();
            }
            Value = value;

            var value1 = await _context.Student.FirstOrDefaultAsync(m => m.ID == id);
            if (value1 == null)
            {
                return NotFound();
            }
            Student = value1;
            return Page();
             

        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Value).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ValueExists(Value.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ValueExists(int id)
        {
          return (_context.Value?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
