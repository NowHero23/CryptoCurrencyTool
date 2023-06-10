using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.Models
{
    public class Rate
    {
        public List<RateItem> Data { get; set; } = new List<RateItem>();
        public long timestamp { get; set; }
    }
}
