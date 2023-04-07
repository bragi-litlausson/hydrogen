using Avalonia.Markup.Xaml;

namespace Hydrogen.Core.Modules.UI.Pages;

public sealed partial class VerticalMenuView : MenuView<VerticalMenuViewModel>
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