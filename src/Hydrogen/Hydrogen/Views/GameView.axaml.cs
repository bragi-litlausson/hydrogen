using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Hydrogen.Views;

public partial class GameView : UserControl
{
    public GameView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}