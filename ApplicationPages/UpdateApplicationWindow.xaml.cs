using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using LastPractical.Context;
using LastPractical.Entities;
using Application = System.Windows.Application;

namespace LastPractical.ApplicationPages;

public partial class UpdateApplicationWindow : Window
{
    private MyDbContext _context = new MyDbContext();
    public ObservableCollection<User> UserExecuter { get; set; }
    public int applicationId;
    public ObservableCollection<Status> Category { get; set; }
    public UpdateApplicationWindow(object dataContext)
    {
        InitializeComponent();
        
        DataContext = dataContext;
        GetUserClient();
    }

    
    void GetUserClient()
    {
        var executer = _context.Users
            .Where(u => u.RoleId == 3)
            .ToList();
        UserExecuter = new ObservableCollection<User>(executer);
        UserExecutorComboBox.ItemsSource = UserExecuter;
        UserExecutorComboBox.DisplayMemberPath = "FullName";

        var category = _context.Statuses.ToList();
        Category = new ObservableCollection<Status>(category);
        StatusApplicationComboBox.ItemsSource = Category;
        StatusApplicationComboBox.DisplayMemberPath = "Name";
    }

    void GetTakeComboBox()
    {
        int applicationId = Convert.ToInt32(ApplicationId.Text);
        int userExecutorId = Convert.ToInt32(UserExecutor.Text);
        int statusId = Convert.ToInt32(StatusId.Text);
        var selectedUser = UserExecuter.FirstOrDefault(u => u.UserId == userExecutorId);
        var selecterStatus = Category.FirstOrDefault(c => c.StatusId == statusId);
        
        if (selectedUser != null && selecterStatus != null)
        {
            UserExecutorComboBox.SelectedItem = selectedUser;
            StatusApplicationComboBox.SelectedItem = selecterStatus;
        }
    }
    
    void UpdateApplication()
    {
        try
        {
            applicationId = Convert.ToInt32(ApplicationId.Text);
            var selectedClient = UserExecutorComboBox.SelectedItem as User;
            var selectedStatus = StatusApplicationComboBox.SelectedItem as Status;
            var description = DescriptionTextBox.Text;
            
            var applicationToUpdate = _context.Applications.Find(applicationId); 
            
            if(applicationToUpdate != null)
            {
                applicationToUpdate.UserIdExecutor = selectedClient.UserId;
                applicationToUpdate.StatusId = selectedStatus.StatusId;
                applicationToUpdate.Description = description;
                
                _context.SaveChanges();
                MessageBox.Show("Данные успешно обновлены!", "Обновление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Объект не найден!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        catch(Exception ex)
        {
            MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    private void UpdateApplicationButton_OnClick(object sender, RoutedEventArgs e)
    {
        UpdateApplication();
    }

    private void UpdateApplicationWindow_OnLoaded(object sender, RoutedEventArgs e)
    {
        GetTakeComboBox();
    }
}