using System;
using System.Collections.Generic;

namespace APIHR.Data;

public partial class User
{
    public int UserCode { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? PositionId { get; set; }

    public int? DepartmentId { get; set; }

    public string? EnumCode { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Address { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }
}
