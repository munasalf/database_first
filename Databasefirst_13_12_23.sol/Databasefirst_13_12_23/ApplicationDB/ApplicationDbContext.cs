using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Databasefirst_13_12_23.ApplicationDB
{
    internal class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-H0S7VNS\\MSSQLSERVER02;Initial catalog = EmployeeTable ;Integrated Security=True;");

        }


}   }
