using System.Diagnostics;
using Avalonia.Interactivity;
using Avalonia.Controls;

using CatApp.Views.Main;


// Linked to the main View behind code
class MainController
{
    // Reference to the main view
    private readonly MainWindow _view;

    public MainController(MainWindow view)
    {
        _view = view;
        ConfigureMainHeader();
    }

    private void ConfigureMainHeader()
    {
        _view.GithubButton.Click += OpenLink;
        _view.AboutButton.Click += OpenLink;
    }

    // Open the link in default browser
    private void OpenLink(object? sender, RoutedEventArgs e)
    {
        // Cast the sender to button and get its link
        string url = ((Button)sender).Tag.ToString();

        // Define a process with the url as the file name
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = url,
            UseShellExecute = true
        };

        // start a process with the defined info
        Process.Start(startInfo);
    }
}