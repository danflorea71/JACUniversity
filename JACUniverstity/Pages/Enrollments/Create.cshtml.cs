using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JACUniverstity.Models;

namespace JACUniverstity.Pages.Enrollments
{
    public class CreateModel : PageModel
    {
        private readonly JACUniverstity.Models.JACUniverstityContext _context;

        public CreateModel(JACUniverstity.Models.JACUniverstityContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CourseID"] = new SelectList(_context.Course, "CourseID", "Title");
        ViewData["StudentID"] = new SelectList(_context.Student, "ID", "FullName");
           
            return Page();
        }

        [BindProperty]
        public Enrollment Enrollment { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Enrollment.Add(Enrollment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}