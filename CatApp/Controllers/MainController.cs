using System.Diagnostics;
using Avalonia.Interactivity;
using Avalonia.Controls;
using System;
using CatApp.Views.Main;
using CatApp.Views.Home;
using CatApp.Views.Click;
using CatApp.Views.FetchData;

// Linked to the main View behind code
class MainController
{
    // Reference to the main view
    private readonly MainWindow _view;

    public MainController(MainWindow view)
    {
        _view = view;
        ConfigureMainHeader();
        ConfigureSideBar();
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

    // Attach changing view to btn click
    private void ConfigureSideBar()
    {
        foreach (var child in _view.SideBar.Children)
        {
            if(child is Button)
            {
                ((Button)child).Click += ChangeView;
            }
        }
    }

    private void ChangeView(object? sender, RoutedEventArgs e)
    {
        string viewName = ((Button)sender).Tag.ToString();

        switch(viewName)
        {
            case "Home":
                Console.WriteLine("Home");
                _view.MainContentArea.Content = new HomeView();
                // ((Button)sender).Content="Clicked";
                break;
            case "Counter":
                Console.WriteLine("Counter");
                _view.MainContentArea.Content = new ClickView(); 
                // ((Button)sender).Content="Clicked";
                break;
            case "FetchData":
                Console.WriteLine("Fetch data");
                _view.MainContentArea.Content = new FetchDataView();
                // ((Button)sender).Content="Clicked";
                break;
            default:
                Console.WriteLine("The view does not exists");
                break;
        }
    }
}