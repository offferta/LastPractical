using System;
using System.Collections.Generic;

namespace LastPractical.Entities;

public partial class Status
{
    public int StatusId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Application> Applications { get; } = new List<Application>();
}
