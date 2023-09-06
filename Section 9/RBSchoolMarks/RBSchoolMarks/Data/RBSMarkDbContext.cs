using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RBSchoolMarks.Models;

namespace RBSchoolMarks.Data
{
    public class RBSMarkDbContext : DbContext
    {
        public RBSMarkDbContext (DbContextOptions<RBSMarkDbContext> options)
            : base(options)
        {
        }

        public DbSet<RBSchoolMarks.Models.SubMark> SubMark { get; set; } = default!;
    }
}
