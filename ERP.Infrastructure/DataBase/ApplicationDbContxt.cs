using ERP.Domain.HRM;
using System;
using System.Data.Entity;
using System.Linq;

namespace ERP.Infrastructure.DataBase
{
  public class ApplicationDbContxt : DbContext
    {
        public ApplicationDbContxt()  : base("name=dbdatabase")
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
