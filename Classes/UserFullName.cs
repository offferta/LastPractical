using System.Configuration;
using LastPractical.Entities;

namespace LastPractical.Entities;

public partial class User
{
    public string FullName => $"{SecondName} {FirstName} {PatronymicName}";
}