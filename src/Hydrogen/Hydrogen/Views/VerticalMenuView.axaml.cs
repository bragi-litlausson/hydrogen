using Avalonia.Markup.Xaml;
using Hydrogen.ViewModels;

namespace Hydrogen.Views;

public sealed partial class VerticalMenuView : MenuViewBase<VerticalMenuViewModel>
{
    public VerticalMenuView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}