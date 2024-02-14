using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using LastPractical.Context;
using LastPractical.Entities;
using Microsoft.EntityFrameworkCore;
using Application = System.Windows.Application;

namespace LastPractical.ApplicationPages;

public partial class ListApplicationPage : Page
{
    private MyDbContext _context = new MyDbContext();
    public ListApplicationPage()
    {
        InitializeComponent();
        GetListApplication();
    }

    void GetListApplication()
    {
        var listApplication = _context.Applications
            .Include(a => a.Status)
            .Select(a => new 
            {
                Application = a,
                UserClient = _context.Users.FirstOrDefault(u => u.UserId == a.UserIdClient),
                UserExecutor = _context.Users.FirstOrDefault(u => u.UserId == a.UserIdExecutor),
                Status = a.Status,
                Description = a.Description,
                DateApplication = a.DateApplication,
                WorkTime = a.WorkTime
            })
            .AsNoTracking()
            .ToList();
        listApplicationDataGrid.ItemsSource = listApplication;
    }

    private void EditApplicationButton_OnClick(object sender, RoutedEventArgs e)
    {
        var selectedApplication = (sender as Button)?.DataContext;

        if (selectedApplication != null)
        {
            var updateApplicationWindow = new UpdateApplicationWindow(selectedApplication);
            updateApplicationWindow.Show();
            updateApplicationWindow.Closing += UpdateApplicationWindowOnClosing ;
        }
    }

    private void UpdateApplicationWindowOnClosing(object? sender, CancelEventArgs e)
    {
        GetListApplication();
    }
}