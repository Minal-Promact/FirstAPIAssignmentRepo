using FirstAPIAssignmentRepo.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace FirstAPIAssignmentRepo.Data
{
    public class EmployeeAPIDBContext : DbContext
    {
        public EmployeeAPIDBContext()
        {
        }

        public EmployeeAPIDBContext(DbContextOptions<EmployeeAPIDBContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("WebApiDatabase");
            }
        }

        public DbSet<Employee> Employee { get; set; }

        
    }
}
