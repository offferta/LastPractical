using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using LastPractical.Entities;
using Application = System.Windows.Application;

namespace LastPractical
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static User? User { get; set; }
        
        public static string? FullName => $"{User?.FirstName} {User?.SecondName} {User?.PatronymicName}";
        
    }
}