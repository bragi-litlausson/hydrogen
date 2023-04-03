using Avalonia.Markup.Xaml;
using Hydrogen.ViewModels;

namespace Hydrogen.Views;

public sealed partial class HorizontalMenuView : MenuViewBase<HorizontalMenuViewModel>
{
    public HorizontalMenuView()
    {
        InitializeComponent();
    }
    
    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}