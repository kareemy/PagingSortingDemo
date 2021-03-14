using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PagingSortingDemo.Models;

namespace PagingSortingDemo.Pages.Professors
{
    public class CreateModel : PageModel
    {
        private readonly PagingSortingDemo.Models.ProfessorContext _context;

        public CreateModel(PagingSortingDemo.Models.ProfessorContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Professor Professor { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Professor.Add(Professor);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
