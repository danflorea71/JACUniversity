﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JACUniverstity.Models;

namespace JACUniverstity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly JACUniverstity.Models.JACUniverstityContext _context;

        public IndexModel(JACUniverstity.Models.JACUniverstityContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
