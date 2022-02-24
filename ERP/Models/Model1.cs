namespace ERP.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<HR_EmployeeInfo> HR_EmployeeInfo { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HR_EmployeeInfo>()
                .Property(e => e.BasicSalary)
                .HasPrecision(10, 2);

            modelBuilder.Entity<HR_EmployeeInfo>()
                .Property(e => e.GrossSalary)
                .HasPrecision(10, 2);
        }
    }
}
