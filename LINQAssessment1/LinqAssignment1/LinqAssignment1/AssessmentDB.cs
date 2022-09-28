using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinqAssignment1
{
    internal class AssessmentDB:DbContext
    {
        public DbSet<Person> movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer("Data Source=VDC01LTC2164; Initial Catalog = BookShow; Integrated Security=True;");
        }
    }
}
