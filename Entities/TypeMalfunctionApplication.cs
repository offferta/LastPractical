using System;
using System.Collections.Generic;

namespace LastPractical.Entities;

public partial class TypeMalfunctionApplication
{
    public int TypeMalfunctionId { get; set; }

    public int ApplicationId { get; set; }

    public int? Count { get; set; }

    public virtual Application Application { get; set; } = null!;

    public virtual TypeMalfunction TypeMalfunction { get; set; } = null!;
}
