using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using System.Diagnostics;
using Avalonia.Interactivity;
using System;

namespace CatApp.Views.Click;

public partial class ClickView : UserControl
{
    public ClickView()
    {
        InitializeComponent();
        ClickController _clc = new(this);
    }
}