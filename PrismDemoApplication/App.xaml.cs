using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using PrismApplicationDemo.TodoModule;

namespace PrismDemoApplication {
    public partial class App {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        protected override Window CreateShell() => Container.Resolve<ShellWindow>();

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<TodoModule>();
            // moduleCatalog.AddModule<NoteModule>();
        }
    }
}
