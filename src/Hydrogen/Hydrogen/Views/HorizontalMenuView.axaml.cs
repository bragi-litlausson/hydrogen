using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Hydrogen.Views;

public partial class HorizontalMenuView : UserControl
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