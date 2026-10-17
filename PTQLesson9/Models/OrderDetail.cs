using System;
using System.Collections.Generic;

namespace PTQLesson9.Models;

public partial class OrderDetail
{
    public int OrderDetailId { get; set; }

    public string? OrderId { get; set; }

    public string? BookId { get; set; }

    public int? Quantity { get; set; }

    public int? Price { get; set; }

    public string? TotalMoney { get; set; }
}
