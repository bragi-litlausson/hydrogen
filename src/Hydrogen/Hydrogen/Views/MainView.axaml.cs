using System;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Hydrogen.ViewModels;

namespace Hydrogen.Views;

public partial class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e);
        
        if(DataContext is not MainViewModel dataContext) return;
        
        dataContext.LoadFirstPage();
    }
}