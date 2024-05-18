using System;
using System.Collections.Generic;

namespace CoreWebApi.Models;

public partial class Shipper
{
    public int Id { get; set; }

    public string? CompanyName { get; set; }

    public string? Phone { get; set; }
}
