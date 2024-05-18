using System;
using System.Collections.Generic;

namespace CoreWebApi.Models;

public partial class Territory
{
    public string Id { get; set; } = null!;

    public string? TerritoryDescription { get; set; }

    public int RegionId { get; set; }

    public virtual ICollection<EmployeeTerritory> EmployeeTerritories { get; set; } = new List<EmployeeTerritory>();
}
