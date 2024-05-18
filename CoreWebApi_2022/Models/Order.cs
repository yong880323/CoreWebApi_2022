using System;
using System.Collections.Generic;

namespace CoreWebApi.Models;

public partial class Order
{
    public int Id { get; set; }

    public DateOnly? OrderDate { get; set; }

    public DateOnly? RequiredDate { get; set; }

    public DateOnly? ShippedDate { get; set; }

    public int? ShipVia { get; set; }

    public decimal Freight { get; set; }

    public string? ShipName { get; set; }

    public string? ShipAddress { get; set; }

    public string? ShipCity { get; set; }

    public string? ShipRegion { get; set; }

    public string? ShipPostalCode { get; set; }

    public string? ShipCountry { get; set; }

    public string? CustomerId { get; set; }

    public int EmployeeId { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
