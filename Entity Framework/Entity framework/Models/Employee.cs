using System;
using System.Collections.Generic;

namespace EntitFrame.Models;

public partial class Employee
{
    public int EmployeeId { get; set; }

    public string? EmpName { get; set; }

    public DateTime? DateofBirth { get; set; }

    public string? Gender { get; set; }

    public int? DeptId { get; set; }

    public virtual Department? Dept { get; set; }
}
