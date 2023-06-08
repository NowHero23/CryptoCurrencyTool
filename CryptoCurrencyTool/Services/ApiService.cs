using CryptoCurrencyTool.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace CryptoCurrencyTool.Services
{
    public class ApiService
    {
        public static async Task<List<CryptoCurrency>> GetAssetsData(string id = "")
        {
            var json = await ConnectingService.GetCurrency(ConnectingService.defaultApiUrl + "assets/" + id);


            if (id == "")
            {
                var obj = new
                {
                    Data = new List<CryptoCurrency>(),
                    Timestamp = default(long)
                };

                obj = JsonConvert.DeserializeAnonymousType(json, obj);
                return obj.Data;
            }
            else
            {
                var obj = new
                {
                    Data = new CryptoCurrency(),
                    Timestamp = default(long)
                };

                obj = JsonConvert.DeserializeAnonymousType(json, obj);

                var tmp = new List<CryptoCurrency>();
                tmp.Add(obj.Data);
                return tmp;
            }
        }

        //api.coincap.io/v2/assets/bitcoin/history?interval=d1&start=1681084800000&end=1681257600000
        public static async Task<History> GetHistoryData(string id, string interval = "d1", long start = 0, long end = 0) //use valid interval: m1, m5, m15, m30, h1, h2, h6, h12, d1
        {
            var url = ConnectingService.defaultApiUrl + "assets/" + id + "/history/" + "?interval=" + interval;

            if (start != 0)
                url += "&start=" + start;
            if (end != 0)
                url += "&end=" + end;

            var json = await ConnectingService.GetCurrency(url);

            History history = JsonConvert.DeserializeObject<History>(json);

            history.Currency = (await GetAssetsData(id))[0];

            return history;
        }

        //api.coincap.io/v2/assets/bitcoin/markets?limit=5&offset=0
        public static async Task<List<Market>> GetMarketData(string id, int limit = 0, int offset = 0)
        {
            var url = ConnectingService.defaultApiUrl + "assets/" + id + "/markets/";

            if (limit != 0 && offset != 0)
                url += "?limit=" + limit;
            else if (limit != 0)
                url += "?limit=" + limit;
            else if (offset != 0)
                url += "?offset=" + offset;

            var json = await ConnectingService.GetCurrency(url);

            var obj = new
            {
                Data = new List<Market>(),
                Timestamp = default(long)
            };

            obj = JsonConvert.DeserializeAnonymousType(json, obj);

            return obj.Data;
        }

        //api.coincap.io/v2/rates/bitcoin
        public static async Task<List<RateItem>> GetRateData(string id = "")
        {
            var url = ConnectingService.defaultApiUrl + "rates/" + id;

            var json = await ConnectingService.GetCurrency(url);

            if (id == "")
            {
                var obj = new
                {
                    Data = new List<RateItem>(),
                    Timestamp = default(long)
                };

                obj = JsonConvert.DeserializeAnonymousType(json, obj);
                return obj.Data;
            }
            else
            {
                var obj = new
                {
                    Data = new RateItem(),
                    Timestamp = default(long)
                };

                obj = JsonConvert.DeserializeAnonymousType(json, obj);

                var tmp = new List<RateItem>();
                tmp.Add(obj.Data);
                return tmp;
            }



        }
    }
}
