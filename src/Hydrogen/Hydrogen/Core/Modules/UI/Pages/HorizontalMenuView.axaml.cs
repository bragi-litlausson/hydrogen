using Avalonia.Markup.Xaml;

namespace Hydrogen.Core.Modules.UI.Pages;

public sealed partial class HorizontalMenuView : MenuView<HorizontalMenuViewModel>
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