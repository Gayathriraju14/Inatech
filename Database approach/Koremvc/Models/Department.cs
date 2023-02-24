using System;
using System.Collections.Generic;

namespace Koremvc.Models;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public decimal? Salary { get; set; }

    public virtual ICollection<Employee> Employees { get; } = new List<Employee>();
}
