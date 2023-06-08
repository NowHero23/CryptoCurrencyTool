using CryptoCurrencyTool.Models;
using CryptoCurrencyTool.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.ViewModels
{
    public class ConvertorViewModel : ViewModelBase
    {
        public static CurrencyStore CurrencyStore { get; private set; }
        public List<CryptoCurrency> CryptoCurrencies
        {
            get => CurrencyStore.CryptoCurrencies;
        }

        private CryptoCurrency _fromCurrency;
        public CryptoCurrency FromCurrency
        {
            get => _fromCurrency;
            set
            {
                _fromCurrency = value;
                OnPropertyChanged("FromCurrency");
                Convert();
            }
        }

        private CryptoCurrency _toCurrency;
        public CryptoCurrency ToCurrency
        {
            get => _toCurrency;
            set
            {
                _toCurrency = value;
                OnPropertyChanged("ToCurrency");
                Convert();
            }
        }

        private double _amount;
        public double Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged("Amount");
                Convert();
            }
        }
        private double _result;
        public double Result
        {
            get => _result;
            set
            {
                _result = value;
                OnPropertyChanged("Result");
            }
        }

        private void Convert()
        {
            if (FromCurrency != null && ToCurrency != null)
                Result = Amount * FromCurrency.PriceUsd / ToCurrency.PriceUsd;
        }


        public ConvertorViewModel(CurrencyStore currencyStore)
        {
            if (CurrencyStore == null) CurrencyStore = currencyStore;
        }
        public ConvertorViewModel()
        {

        }
    }
}
