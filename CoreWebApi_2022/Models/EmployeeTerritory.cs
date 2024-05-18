using System;
using System.Collections.Generic;

namespace CoreWebApi.Models;

public partial class EmployeeTerritory
{
    public string Id { get; set; } = null!;

    public string? TerritoryId { get; set; }

    public int? EmployeeId { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual Territory? Territory { get; set; }
}
