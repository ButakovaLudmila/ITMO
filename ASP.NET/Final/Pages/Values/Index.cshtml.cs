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
    public class IndexModel : PageModel
    {
        private readonly Final.Data.FinalContext _context;

        public IndexModel(Final.Data.FinalContext context)
        {
            _context = context;
        }

        public IList<Value> Value { get;set; } = default!;
        public IList<Theme> Theme { get; set; } = default!;
        public IList<Student> Student { get; set; } = default!;
        public async Task OnGetAsync()
        {
            if (_context.Value != null)
            {
                Value = await _context.Value.ToListAsync();
                Theme = await _context.Theme.ToListAsync();
                Student = await _context.Student.ToListAsync();
            }
        }
    }
}
