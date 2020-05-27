using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JACUniverstity.Models;

namespace JACUniverstity.Pages.Enrollments
{
    public class IndexModel : PageModel
    {
        private readonly JACUniverstity.Models.JACUniverstityContext _context;

        public IndexModel(JACUniverstity.Models.JACUniverstityContext context)
        {
            _context = context;
        }

        public IList<Enrollment> Enrollment { get;set; }

        public async Task OnGetAsync()
        {
            Enrollment = await _context.Enrollment
                .Include(e => e.Course)
                .Include(e => e.Student).ToListAsync();
        }
    }
}
