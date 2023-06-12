using CryptoCurrencyTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.Stores
{
    public class HistoryStore
    {
        private static HistoryStore _instance;

        private static History _history = new History();
        public History History
        {
            get => _history;
            set
            {
                _history = value;
                OnHistoryChanged();
            }
        }

        public delegate void Action();
        public event Action HistoryChanged;
        private void OnHistoryChanged()
        {
            HistoryChanged?.Invoke();
        }

        public static HistoryStore GetInstance() => _instance ?? (_instance = new HistoryStore());
        private HistoryStore() { }
    }
}
