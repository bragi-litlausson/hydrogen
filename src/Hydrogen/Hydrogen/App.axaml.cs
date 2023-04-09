using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using Hydrogen.Core;
using Hydrogen.Core.Modules.EventSystem;
using Hydrogen.ViewModels;
using Hydrogen.Views;

namespace Hydrogen;

public partial class App : Application
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        var serviceManager = InitializeServices();
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            desktop.MainWindow = new MainWindow
            {
                DataContext = new MainViewModel(serviceManager)
            };
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = new MainView
            {
                DataContext = new MainViewModel(serviceManager)
            };
        }

        base.OnFrameworkInitializationCompleted();
    }

    private IServiceContainer InitializeServices()
    {
        var messageService = new MessageService();
        var serviceManager = new ServiceContainer(messageService);

        return serviceManager;
    }
}