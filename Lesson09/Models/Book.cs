using System;
using System.Collections.Generic;

namespace Lesson09.Models;

public partial class Book
{
    public string BookId { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string? Author { get; set; }

    public int? Release { get; set; }

    public double? Price { get; set; }

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public int? PublisherId { get; set; }

    public int? CategoryId { get; set; }
}
