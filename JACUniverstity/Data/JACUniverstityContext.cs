using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using JACUniverstity.Models;

namespace JACUniverstity.Models
{
    public class JACUniverstityContext : DbContext
    {
        public JACUniverstityContext (DbContextOptions<JACUniverstityContext> options)
            : base(options)
        {
        }

        public DbSet<JACUniverstity.Models.Student> Student { get; set; }

        public DbSet<JACUniverstity.Models.Course> Course { get; set; }

        public DbSet<JACUniverstity.Models.Enrollment> Enrollment { get; set; }

    }
}
