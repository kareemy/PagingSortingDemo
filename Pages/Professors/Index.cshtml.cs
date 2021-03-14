using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PagingSortingDemo.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PagingSortingDemo.Pages.Professors
{
    public class IndexModel : PageModel
    {
        private readonly PagingSortingDemo.Models.ProfessorContext _context;

        public IndexModel(PagingSortingDemo.Models.ProfessorContext context)
        {
            _context = context;
        }

        public IList<Professor> Professor { get;set; }

        // Paging support
        // PageNum is the current page number we are on
        // PageSize is how many records will be displayed per page. 
        // PageNum needs BindProperty because the user decides which page we are on.
        // The user selects the page number
        // SupportsGet = true allows us to pass the PageNum through the URL with an HTTP Get Parameter 
        // This is necessary, because page numbers are not passed through normal forms
        [BindProperty(SupportsGet = true)]
        public int PageNum {get; set;} = 1;
        public int PageSize {get; set;} = 10;

        // Sorting support
        [BindProperty(SupportsGet = true)]
        public string CurrentSort {get; set;}
        // Second sorting technique with a SelectList
        public SelectList SortList {get; set;}

        public async Task OnGetAsync()
        {
            //Professor = await _context.Professor.ToListAsync();
            // Sorting support
            // Break up query. Do basic query first that just selects all professors
            var query = _context.Professor.Select(p => p);
            List<SelectListItem> sortItems = new List<SelectListItem> {
                new SelectListItem { Text = "FirstName Ascending", Value = "first_asc" },
                new SelectListItem { Text = "FirstName Descending", Value = "first_desc"}
            };
            SortList = new SelectList(sortItems, "Value", "Text", CurrentSort);

            switch (CurrentSort)
            {
                // If user selected "first_asc", modify query to sort by first name ascending order
                case "first_asc": 
                    query = query.OrderBy(p => p.FirstName);
                    break;
                // If user selected "first_desc", modify query to sort by first name descending
                case "first_desc":
                    query = query.OrderByDescending(p => p.FirstName);
                    break;
                // Add more sorting cases as needed
            }

            // Retrieve just the professors for the page we are on
            // Use .Skip() and .Take() to select them
            Professor = await query.Skip((PageNum-1)*PageSize).Take(PageSize).ToListAsync();
        }
    }
}
