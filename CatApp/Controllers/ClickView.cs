using System.Diagnostics;
using Avalonia.Interactivity;
using Avalonia.Controls;
using System;
using CatApp.Views.Main;
using CatApp.Views.Home;
using CatApp.Views.Click;
using CatApp.Views.FetchData;

// Linked to the main View behind code
class ClickController
{
    // Reference to the click view
    private readonly ClickView _view;
    private int Counter { get; set; } = 0;
    public ClickController(ClickView view)
    {
        _view = view;
        InitButton();
    }

    private void InitButton()
    {
        _view.CounterButton.Click += ClickButton;
    }

    private void ClickButton(object? sender, RoutedEventArgs e)
    {
        Counter++;
        _view.CounterButtonText.Text = $"You clicked {Counter} times";
        Console.WriteLine("Clicked");
    }
}