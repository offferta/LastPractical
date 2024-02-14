using System.Windows;
using System.Windows.Input;
using LastPractical.ApplicationPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LastPractical;

public partial class ApplicationFrameWindow : Window
{
    public ApplicationFrameWindow()
    {
        InitializeComponent();
        ApplicationFrame.Navigate(new AddApplicationPage());
        FullName.Content = App.FullName;
    }

    private void ApplicationButton_OnClick(object sender, RoutedEventArgs e)
    {
        ApplicationFrame.Navigate(new AddApplicationPage());
    }

    private void ListApplicationButton_OnClick(object sender, RoutedEventArgs e)
    {
        ApplicationFrame.Navigate(new ListApplicationPage());
    }

    private void FullName_OnMouseEnter(object sender, MouseEventArgs e)
    {
        new AuthorizationWindow().Show();
        Close();
    }
}