using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SVOffice.Models
{
    public class SVOfficeDbContext : DbContext
    {
        public SVOfficeDbContext(DbContextOptions<SVOfficeDbContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}