using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.Models
{
    public class CryptoCurrencyTable
    {
        public List<CryptoCurrency> Data { get; set; } = new List<CryptoCurrency>();
        public long timestamp { get; set; }
    }
}
