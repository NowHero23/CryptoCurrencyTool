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

        public CurrencyStore()
        {
            CryptoCurrencyTable tmp;
            
            Task<CryptoCurrencyTable> temp = ApiService.GetAssetsDataAsync();

            tmp = temp.GetAwaiter().GetResult();

            CryptoCurrencies = tmp.Data;
        }
    }
}
