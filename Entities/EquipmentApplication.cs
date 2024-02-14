using System;
using System.Collections.Generic;

namespace LastPractical.Entities;

public partial class EquipmentApplication
{
    public int EquipmentId { get; set; }

    public int ApplicationId { get; set; }

    public int Count { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual Equipment Equipment { get; set; } = null!;
}
