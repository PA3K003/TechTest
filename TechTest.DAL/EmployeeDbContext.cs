namespace TechTest.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using System.Data;

    public partial class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext()
            : base("name=TechTestDB")
        {
           
        }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
