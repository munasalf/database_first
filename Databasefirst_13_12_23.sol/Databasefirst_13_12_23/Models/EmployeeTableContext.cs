using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Databasefirst_13_12_23.Models
{
    public partial class EmployeeTableContext : DbContext
    {
        public EmployeeTableContext()
        {
        }

        public EmployeeTableContext(DbContextOptions<EmployeeTableContext> options)
            : base(options)
        {
        }

        public virtual DbSet<EmployeeInfor> EmployeeInfors { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-H0S7VNS\\MSSQLSERVER02;Initial Catalog=EmployeeTable;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeInfor>(entity =>
            {
                entity.HasKey(e => e.EmpId);

                entity.ToTable("EmployeeInfor");

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .HasColumnName("empId")
                    .IsFixedLength();

                entity.Property(e => e.EmployeeName).HasMaxLength(50);

                entity.Property(e => e.ExprinceYears).HasColumnName("Exprince years");

                entity.Property(e => e.Mobille).HasColumnName("mobille");

                entity.Property(e => e.Skills).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
