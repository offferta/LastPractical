using System;
using System.Collections.Generic;

namespace LastPractical.Entities;

public partial class Equipment
{
    public int EquipmentId { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EquipmentApplication> EquipmentApplications { get; } = new List<EquipmentApplication>();
}
