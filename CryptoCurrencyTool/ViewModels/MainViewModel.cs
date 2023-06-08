using CryptoCurrencyTool.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private readonly NavigationStore _navigationStore;
        public ViewModelBase CurrentViewModel => _navigationStore.CurrentViewModel;

        public NavigationBarViewModel NavigationBarViewModel { get; }

        public MainViewModel(NavigationStore navigationStore, NavigationBarViewModel navigationBarViewModel)
        {
            _navigationStore = navigationStore;
           
            NavigationBarViewModel = navigationBarViewModel;

            _navigationStore.CurrentViewModelChanged += OnCurrentViewModelChanged;
        }
        private void OnCurrentViewModelChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

    }
}
