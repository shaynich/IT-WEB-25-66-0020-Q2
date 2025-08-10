using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentSystem.Models;

namespace StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public StudentSystemContext (DbContextOptions<StudentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<StudentSystem.Models.Course> Course { get; set; } = default!;
        public DbSet<StudentSystem.Models.Student> Student { get; set; } = default!;
    }
}
