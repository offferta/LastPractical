using System;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using LastPractical.Context;
using LastPractical.Entities;
using Application = LastPractical.Entities.Application;

namespace LastPractical.ApplicationPages;

public partial class AddApplicationPage : Page
{
    private MyDbContext _context = new MyDbContext();
    public string dateTime = DateTime.Today.ToString(); 
    public AddApplicationPage()
    {
        InitializeComponent();
        GetUserClient();
    }

    public ObservableCollection<User> UserClietn { get; set; }
    public ObservableCollection<User> UserExecuter { get; set; }
    public ObservableCollection<Status> Category { get; set; }
    
    void GetUserClient()
    {
        var clients = _context.Users
            .Where(u => u.RoleId == 2)
            .ToList();
        
        UserClietn = new ObservableCollection<User>(clients);
        UserClietnComboBox.ItemsSource = UserClietn;
        UserClietnComboBox.DisplayMemberPath = "FullName";
        UserClietnComboBox.SelectedIndex = 0;
        
        var executer = _context.Users
            .Where(u => u.RoleId == 3)
            .ToList();

        UserExecuter = new ObservableCollection<User>(executer);
        UserExecutorComboBox.ItemsSource = UserExecuter;
        UserExecutorComboBox.DisplayMemberPath = "FullName";
        UserExecutorComboBox.SelectedIndex = 0;

        var category = _context.Statuses.ToList();
        Category = new ObservableCollection<Status>(category);
        StatusApplicationComboBox.ItemsSource = Category;
        StatusApplicationComboBox.DisplayMemberPath = "Name";
        StatusApplicationComboBox.SelectedIndex = 1;
    }

    void AddApplication()
    {
        var application = new Application();
        try
        {
            var selectedClient = (UserClietnComboBox.SelectedItem as User).UserId;
            var selectedExecutor = (UserExecutorComboBox.SelectedItem as User).UserId;
            var selectedStatus = (StatusApplicationComboBox.SelectedItem as Status).StatusId;

            if (selectedClient != null && selectedExecutor != null && selectedStatus != null && DescriptionTextBox.Text != "")
            {
                application = new Application()
                {
                    UserIdClient = selectedClient,
                    UserIdExecutor = selectedExecutor,
                    StatusId = selectedStatus,
                    Description = DescriptionTextBox.Text,
                    DateApplication = Convert.ToDateTime(dateTime),
                    WorkTime = "00:00:00"
                };
                try
                {
                    _context.Applications.Add(application);
                    _context.SaveChangesAsync();
                    MessageBox.Show("Добавление прошло успешно!","Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Проверьте корректность данных " + e.Message ,"Добавление", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Проверьте корректность данных","Добавление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        catch (Exception e)
        {
            MessageBox.Show("Проверьте корректность данных " + e.Message,"Добавление", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void AddApplicationButton_OnClick(object sender, RoutedEventArgs e)
    {
        AddApplication();
    }

    private void DatePicker1_OnSelectedDateChanged(object? sender, SelectionChangedEventArgs e)
    {
        dateTime = datePicker1.ToString();
    }
}