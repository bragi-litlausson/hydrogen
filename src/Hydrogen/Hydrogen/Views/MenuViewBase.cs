using System;
using System.Collections;
using Avalonia.Controls;
using Hydrogen.Models;
using Hydrogen.TemplatedControls;
using Hydrogen.ViewModels;

namespace Hydrogen.Views;

public abstract class MenuViewBase<TDataContext> : UserControl 
    where TDataContext : MenuViewModelBase
{
    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e);

        if (DataContext is not TDataContext dataContext) return;

        var buttonModels = dataContext.ButtonModels;

        ValidateButtonModels(buttonModels);

        for (var i = 0; i < buttonModels.Count; i++) InstantiateButton(i, buttonModels[i]);
        if (buttonModels.Count < 4) HideUnusedButtons(buttonModels.Count);
    }

    private void ValidateButtonModels(ICollection models)
    {
        switch (models.Count)
        {
            case 0:
                throw new ArgumentOutOfRangeException("buttonModels.Count",
                    "Menu requires at least one button model");
            case > 4:
                throw new ArgumentOutOfRangeException("buttonModels.Count", "Menu supports up to 4 buttons");
        }
    }

    private void InstantiateButton(int index, ButtonModel buttonModel)
    {
        var button = FindButtonControl(index);
        button.Setup(buttonModel);
    }

    private void HideUnusedButtons(int firstUnusedIndex)
    {
        for (var i = firstUnusedIndex; i < 4; i++)
        {
            var button = FindButtonControl(i);
            button.Setup(null);
        }
    }

    private MenuButtonControl FindButtonControl(int index) => this.FindControl<MenuButtonControl>($"Option{index}");
}