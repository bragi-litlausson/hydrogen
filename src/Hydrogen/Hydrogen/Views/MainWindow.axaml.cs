using System;
using Avalonia.Controls;
using Hydrogen.ViewModels;

namespace Hydrogen.Views;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e);
        
        if(DataContext is not MainViewModel dataContext) return;
        
        dataContext.LoadFirstPage();
    }
}