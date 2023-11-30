using Avalonia.Controls;

namespace CatApp.Views.Main;

public partial class MainWindow : Window
{
    // Controller linking
    private readonly MainController _ctrl;
    public MainWindow()
    {
        InitializeComponent();
        _ctrl = new(this);
    }
}