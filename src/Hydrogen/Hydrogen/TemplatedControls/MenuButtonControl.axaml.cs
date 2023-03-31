using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;

namespace Hydrogen.TemplatedControls;

public sealed class MenuButtonControl : TemplatedControl
{
    public static readonly StyledProperty<string> TextProperty = AvaloniaProperty.Register<MenuButtonControl, string>(
        nameof(Text), "Hydrogen");

    public string Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }   
}