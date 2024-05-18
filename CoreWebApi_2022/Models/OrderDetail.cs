using System;
using System.Collections.Generic;

namespace CoreWebApi.Models;

public partial class OrderDetail
{
    public string Id { get; set; } = null!;

    public decimal UnitPrice { get; set; }

    public int Quantity { get; set; }

    public double Discount { get; set; }

    public int? ProductId { get; set; }

    public int? OrderId { get; set; }

    public virtual Order? Order { get; set; }

    public virtual Product? Product { get; set; }
}
