using System;
using System.Collections.Generic;

namespace LastPractical.Entities;

public partial class Application
{
    public int ApplicationId { get; set; }

    public int UserIdClient { get; set; }

    public int UserIdExecutor { get; set; }

    public int StatusId { get; set; }

    public string Description { get; set; } = null!;

    public DateTime DateApplication { get; set; }

    public String WorkTime { get; set; }

    public virtual ICollection<EquipmentApplication> EquipmentApplications { get; } = new List<EquipmentApplication>();

    public virtual Status Status { get; set; } = null!;

    public virtual ICollection<TypeMalfunctionApplication> TypeMalfunctionApplications { get; } = new List<TypeMalfunctionApplication>();

    public virtual User UserIdClientNavigation { get; set; } = null!;

    public virtual User UserIdExecutorNavigation { get; set; } = null!;
}
