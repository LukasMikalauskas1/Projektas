using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CourseAPI.Models;

namespace CourseAPI.Data
{
    public class CourseAPIContext : DbContext
    {
        public CourseAPIContext (DbContextOptions<CourseAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CourseAPI.Models.Course> Course { get; set; } = default!;
    }
}
