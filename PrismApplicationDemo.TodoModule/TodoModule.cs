using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using PrismApplicationDemo.TodoModule.Views;

namespace PrismApplicationDemo.TodoModule {
    public class TodoModule : IModule {
        private readonly IRegionManager _regionManager;

        public TodoModule(IRegionManager regionManager) {
            _regionManager = regionManager;
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            _regionManager.RegisterViewWithRegion<TodolistView>("ContentRegion");
        }
    }
}
