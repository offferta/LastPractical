using System;
using System.Collections.Generic;

namespace LastPractical.Entities;

public partial class User
{
    public int UserId { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public int RoleId { get; set; }

    public string FirstName { get; set; } = null!;

    public string SecondName { get; set; } = null!;

    public string PatronymicName { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Application> ApplicationUserIdClientNavigations { get; } = new List<Application>();

    public virtual ICollection<Application> ApplicationUserIdExecutorNavigations { get; } = new List<Application>();
    
    public virtual Role Role { get; set; } = null!;
}
