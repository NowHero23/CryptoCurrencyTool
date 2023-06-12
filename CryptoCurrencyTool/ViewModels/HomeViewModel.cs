using CryptoCurrencyTool.Commands;
using CryptoCurrencyTool.Models;
using CryptoCurrencyTool.Services;
using CryptoCurrencyTool.Stores;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CryptoCurrencyTool.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public static ICommand SearchCommand { get; private set; }
        public static ICommand NavigateHistoryCommand { get; private set; }
        public static ICommand OpenUrlCommand { get; private set; }

        public List<CryptoCurrency> _cryptoCurrencies;
        public List<CryptoCurrency> CryptoCurrencies
        {
            get => _cryptoCurrencies;
            set
            {
                _cryptoCurrencies = value;
                OnPropertyChanged("CryptoCurrencies");
            }
        }
        public static CurrencyStore CurrencyStore { get; private set; }

        private string _searchText;
        public string SearchText
        {
            get { return _searchText; }
            set
            {
                _searchText = value;
                OnPropertyChanged("SearchText");
            }
        }

        
        public HomeViewModel(CurrencyStore currencyStore, ParameterNavigationService<string, HistoryViewModel> historyNavigationService)
        {
            if (CurrencyStore == null) CurrencyStore = currencyStore;
            if (CryptoCurrencies == null) CryptoCurrencies = CurrencyStore.CryptoCurrencies;
            
            SearchCommand = new RelayCommand(() => 
            {
                if (string.IsNullOrEmpty(SearchText))
                    CryptoCurrencies = CurrencyStore.CryptoCurrencies;
                else
                {
                    CryptoCurrencies = CurrencyStore.CryptoCurrencies.Where(
                    c => c.Id.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                    || c.Name.Contains(SearchText, StringComparison.OrdinalIgnoreCase)
                    ).OrderBy(c => c.Rank).ToList<CryptoCurrency>();

                }
            });


            NavigateHistoryCommand = new ParameterNavigeteCommand<string, HistoryViewModel>(historyNavigationService);


            OpenUrlCommand = new DelegateCommand<string>((Explorer) =>
            {
                if (!string.IsNullOrEmpty(Explorer))
                {
                    try
                    {
                        Process.Start(new ProcessStartInfo
                        {
                            FileName = Explorer,
                            UseShellExecute = true
                        });
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }, (Explorer) => Explorer.Length > 0);

            CurrencyStore.CryptoCurrencyChanged += CryptoCurrenciesChangedEventHandler;
        }

        public override void Dispose()
        {
            CurrencyStore.CryptoCurrencyChanged -= CryptoCurrenciesChangedEventHandler;
            base.Dispose();
        }

        private void CryptoCurrenciesChangedEventHandler()
        {
            OnPropertyChanged("CryptoCurrencies");
        }
    }
}
