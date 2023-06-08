using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.Models
{
    public class History
    {
        public CryptoCurrency Currency { get; set; }
        public List<HistoryItem> Data { get; set; }
        public long timestamp { get; set; }
    }
}
