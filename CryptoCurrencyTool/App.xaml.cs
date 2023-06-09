﻿using CryptoCurrencyTool.Services;
using CryptoCurrencyTool.Stores;
using CryptoCurrencyTool.ViewModels;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading;
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
        private readonly CurrencyStore _currencyStore;
        private readonly HistoryStore _historyStore;

        public App()
        {
            _navigationStore = NavigationStore.GetInstance();
            _currencyStore = CurrencyStore.GetInstance();
            _historyStore = HistoryStore.GetInstance();

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;  
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            var langCode = CryptoCurrencyTool.Properties.Settings.Default.languageCode;
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(langCode);


            NavigationService<HomeViewModel> homeNavigationService = CreateHomeNavigationService();
            homeNavigationService.Navigate();

            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(_navigationStore, CreateNavigationBarViewModel())
            };
            MainWindow.Show();

            base.OnStartup(e);

            //new HistoryViewModel(_historyStore);
        }

        private NavigationBarViewModel CreateNavigationBarViewModel()
        {
            return new NavigationBarViewModel(
                CreateHomeNavigationService(),
                CreateConvertorNavigationService(),
                CreateSettingsNavigationService()
                );
        }

        private NavigationService<HomeViewModel> CreateHomeNavigationService()
        {
            return new NavigationService<HomeViewModel>(
                _navigationStore,
                () => new HomeViewModel(_currencyStore, CreateHistoryNavigationService())
                );
        }
        private NavigationService<ConvertorViewModel> CreateConvertorNavigationService()
        {
            return new NavigationService<ConvertorViewModel>(
                _navigationStore,
                () => new ConvertorViewModel(_currencyStore)
                );
        }
        private NavigationService<SettingsViewModel> CreateSettingsNavigationService()
        {
            return new NavigationService<SettingsViewModel>(
                _navigationStore,
                () => new SettingsViewModel()
                );
        }
        public ParameterNavigationService<string, HistoryViewModel> CreateHistoryNavigationService()
        {
            return new ParameterNavigationService<string, HistoryViewModel>(
                _navigationStore,
                parameter => new HistoryViewModel(_historyStore, parameter)
            );
        }


        public event Action CurrentViewModelChanged;
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
