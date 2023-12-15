using System;
using System.Collections.Generic;

namespace Databasefirst_13_12_23.Models
{
    public partial class EmployeeInfor
    {
        public string EmpId { get; set; } = null!;
        public string EmployeeName { get; set; } = null!;
        public int? Mobille { get; set; }
        public string Skills { get; set; } = null!;
        public int ExprinceYears { get; set; }
    }
}
