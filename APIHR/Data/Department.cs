using System;
using System.Collections.Generic;

namespace APIHR.Data;

public partial class Department
{
    public int DepartmentId { get; set; }

    public string? Description { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool? IsActive { get; set; }
}
