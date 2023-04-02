using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using CommunityToolkit.Mvvm.Input;
using Hydrogen.Models;

namespace Hydrogen.TemplatedControls;

public partial class MenuButtonControl : TemplatedControl
{
    public static readonly StyledProperty<string> TextProperty = AvaloniaProperty.Register<MenuButtonControl, string>(
        nameof(Text), "Hydrogen");

    private Action _onClick;
    
    public string Text
    {
        get => GetValue(TextProperty);
        set => SetValue(TextProperty, value);
    }
    
    public void Setup(ButtonModel? model)
    {
        if (model is null)
        {
            IsVisible = false;
            return;
        }

        Text = model.Text;
        _onClick = model.OnClick;
    }

    [RelayCommand]
    private void Click()
    {
        _onClick?.Invoke();
    }
}