using CryptoCurrencyTool.Services;
using CryptoCurrencyTool.Stores;
using CryptoCurrencyTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace CryptoCurrencyTool
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly NavigationStore _navigationStore;
        private readonly NavigationBarViewModel _navigationBarViewModel;

        public App()
        {
            _navigationStore = new NavigationStore();
            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;  
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            NavigationService<HomeViewModel> homeNavigationService = CreateHomeNavigationService();
            homeNavigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore, CreateNavigationBarViewModel()) //CreateNavigationBarViewModel()
            };
            MainWindow.Show();

            base.OnStartup(e);
        }

        private NavigationBarViewModel CreateNavigationBarViewModel()
        {
            return new NavigationBarViewModel(
                CreateHomeNavigationService(),
                CreateConvertorNavigationService()
                );
        }

        private NavigationService<HomeViewModel> CreateHomeNavigationService()
        {
            return new NavigationService<HomeViewModel>(
                _navigationStore,
                () => new HomeViewModel()
                );
        }
        private NavigationService<ConvertorViewModel> CreateConvertorNavigationService()
        {
            return new NavigationService<ConvertorViewModel>(
                _navigationStore,
                () => new ConvertorViewModel()
                );
        }

        
        public event Action CurrentViewModelChanged;
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
