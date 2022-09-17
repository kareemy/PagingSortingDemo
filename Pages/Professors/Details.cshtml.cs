using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagingSortingDemo.Models;

namespace PagingSortingDemo.Pages.Professors
{
    public class DetailsModel : PageModel
    {
        private readonly PagingSortingDemo.Models.ProfessorContext _context;

        public DetailsModel(PagingSortingDemo.Models.ProfessorContext context)
        {
            _context = context;
        }

      public Professor Professor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Professor == null)
            {
                return NotFound();
            }

            var professor = await _context.Professor.FirstOrDefaultAsync(m => m.ID == id);
            if (professor == null)
            {
                return NotFound();
            }
            else 
            {
                Professor = professor;
            }
            return Page();
        }
    }
}
