using System.Windows;
using Prism.Ioc;
using PrismApplicationDemo.NoteModule;
using PrismApplicationDemo.TodoModule;

namespace PrismDemoApplication {
    public partial class App {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.Register<TodoModule>();
            containerRegistry.Register<NoteModule>();
        }

        protected override Window CreateShell() => Container.Resolve<ShellWindow>();
    }
}
