using System.Windows;
using PiecewiseLinearFunctionDesigner.Core;
using PiecewiseLinearFunctionDesigner.DomainModel.Services;
using PiecewiseLinearFunctionDesigner.Localization;
using PiecewiseLinearFunctionDesigner.Module.Declaration;
using PiecewiseLinearFunctionDesigner.Module.Demonstration;
using PiecewiseLinearFunctionDesigner.Module.Menu;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using PiecewiseLinearFunctionDesigner.Views;

namespace PiecewiseLinearFunctionDesigner
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<IMessageService, MessageService>();
            containerRegistry.RegisterSingleton<IClipboardService, ClipboardService>();
            containerRegistry.RegisterSingleton<IFileSystemService, FileSystemService>();
            containerRegistry.RegisterSingleton<IProjectService, ProjectService>();
            containerRegistry.RegisterSingleton<IPointsConverter, CsvPointsConverter>();
            containerRegistry.RegisterSingleton<ITextLocalization, RussianTextLocalization>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MenuModule>();
            moduleCatalog.AddModule<DemonstrationModule>();
            moduleCatalog.AddModule<DeclarationModule>();
        }
    }
}
