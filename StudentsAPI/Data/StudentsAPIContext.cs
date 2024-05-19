using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentsAPI.Models;

namespace StudentsAPI.Data
{
    public class StudentsAPIContext : DbContext
    {
        public StudentsAPIContext (DbContextOptions<StudentsAPIContext> options)
            : base(options)
        {
        }

        public DbSet<StudentsAPI.Models.Student> Student { get; set; } = default!;
		public DbSet<StudentsAPI.Models.Enrollment> Enrollment { get; set; }

	}
}
