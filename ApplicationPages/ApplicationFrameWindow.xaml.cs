using System.Windows;
using LastPractical.ApplicationPages;

namespace LastPractical;

public partial class ApplicationFrameWindow : Window
{
    public ApplicationFrameWindow()
    {
        InitializeComponent();
        ApplicationFrame.Navigate(new AddApplicationPage());
    }

    private void ApplicationButton_OnClick(object sender, RoutedEventArgs e)
    {
        ApplicationFrame.Navigate(new AddApplicationPage());
    }

    private void ListApplicationButton_OnClick(object sender, RoutedEventArgs e)
    {
        ApplicationFrame.Navigate(new ListApplicationPage());
    }
}