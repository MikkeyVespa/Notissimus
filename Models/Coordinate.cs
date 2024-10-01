using System;
using System.Collections.Generic;

namespace Notiss.Models;

public partial class Coordinate
{
    public int Id { get; set; }

    public string? CoordinatesJson { get; set; }

    public DateTime? CreatedAt { get; set; } = DateTime.Now;
}
