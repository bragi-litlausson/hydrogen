using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Hydrogen.Views;

public partial class VerticalMenuView : UserControl
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