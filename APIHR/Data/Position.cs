using System;
using System.Collections.Generic;

namespace APIHR.Data;

public partial class Position
{
    public int PositionId { get; set; }

    public string? Description { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public bool? IsActive { get; set; }
}
