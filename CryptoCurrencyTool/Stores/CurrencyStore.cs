using CryptoCurrencyTool.Models;
using CryptoCurrencyTool.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace CryptoCurrencyTool.Stores
{
    public class CurrencyStore
    {
        private static CurrencyStore _instance;
        private static List<CryptoCurrency> _cryptocurrencies = new List<CryptoCurrency>();
        public List<CryptoCurrency> CryptoCurrencies
        {
            get => _cryptocurrencies;
            set
            {
                _cryptocurrencies = value;
                OnCryptoCurrencyChanged();
            }
        }

        public event Action CryptoCurrencyChanged;
        private void OnCryptoCurrencyChanged()
        {
            CryptoCurrencyChanged?.Invoke();
        }

        private CurrencyStore()
        {
            Task<List<CryptoCurrency>> temp = ApiService.GetAssetsDataAsync();

            List<CryptoCurrency> tmp = temp.GetAwaiter().GetResult();

            CryptoCurrencies = tmp;
        }
        public static CurrencyStore GetInstance() => _instance ?? (_instance = new CurrencyStore());
        
    }
}
