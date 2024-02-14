using System;
using System.Collections.Generic;

namespace LastPractical.Entities;

public partial class TypeMalfunction
{
    public int TypeMalfunctionId { get; set; }

    public string Name { get; set; } = null!;

    public decimal Price { get; set; }

    public virtual ICollection<TypeMalfunctionApplication> TypeMalfunctionApplications { get; } = new List<TypeMalfunctionApplication>();
}
