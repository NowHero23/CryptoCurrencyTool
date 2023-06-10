using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.Models
{
    public class MarketTable
    {
        public List<Market> Data { get; set; } = new List<Market>();
        public long timestamp { get; set; }
    }
}
