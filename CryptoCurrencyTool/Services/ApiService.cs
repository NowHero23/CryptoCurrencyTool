using CryptoCurrencyTool.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace CryptoCurrencyTool.Services
{
    public class ApiService
    {
        public static async Task<CryptoCurrencyTable> GetAssetsDataAsync(string id = "")
        {
            CryptoCurrencyTable tmp = new CryptoCurrencyTable();
            
            string json = await ConnectingService.GetDataAsync("assets/" + id);

            if (json == null) return tmp;
            
            try
            {
                tmp = JsonConvert.DeserializeObject<CryptoCurrencyTable>(json);
            }
            catch (Exception)
            {
                var obj = new
                {
                    Data = new CryptoCurrency(),
                    Timestamp = default(long)
                };

                obj = JsonConvert.DeserializeAnonymousType(json, obj);
                tmp.Data.Add(obj.Data);
                tmp.timestamp = obj.Timestamp;
            }

            return tmp;
        }

        //api.coincap.io/v2/assets/bitcoin/history?interval=d1&start=1681084800000&end=1681257600000
        public static async Task<History> GetHistoryDataAsync(string id, string interval = "d1", long start = 0, long end = 0) //use valid interval: m1, m5, m15, m30, h1, h2, h6, h12, d1
        {
            History history = new History();

            var url =  "assets/" + id + "/history/" + "?interval=" + interval;
            if (start != 0)
                url += "&start=" + start;
            if (end != 0)
                url += "&end=" + end;

            var json = await ConnectingService.GetDataAsync(url);
            if (json == null) return history;

            history = JsonConvert.DeserializeObject<History>(json);
            history.Currency = (await GetAssetsDataAsync(id)).Data[0];

            return history;
        }

        //api.coincap.io/v2/assets/bitcoin/markets?limit=5&offset=0
        public static async Task<MarketTable> GetMarketDataAsync(string id, int limit = 0, int offset = 0)
        {
            MarketTable tmp = new MarketTable();

            var url = "assets/" + id + "/markets/";
            if (limit != 0 && offset != 0)
                url += "?limit=" + limit;
            else if (limit != 0)
                url += "?limit=" + limit;
            else if (offset != 0)
                url += "?offset=" + offset;

            var json = await ConnectingService.GetDataAsync(url);
            if (json == null) return tmp;

            try
            {
                tmp = JsonConvert.DeserializeObject<MarketTable>(json);
            }
            catch (Exception)
            {
                var obj = new
                {
                    Data = new Market(),
                    Timestamp = default(long)
                };

                obj = JsonConvert.DeserializeAnonymousType(json, obj);
                tmp.Data.Add(obj.Data);
                tmp.timestamp = obj.Timestamp;
            }

            return tmp;
        }

        //api.coincap.io/v2/rates/bitcoin
        public static async Task<Rate> GetRateDataAsync(string id = "")
        {
            Rate tmp = new Rate();

            var json = await ConnectingService.GetDataAsync("rates/" + id);
            if (json == null) return tmp;

            try
            {
                tmp = JsonConvert.DeserializeObject<Rate>(json);
            }
            catch (Exception)
            {
                var obj = new
                {
                    Data = new RateItem(),
                    Timestamp = default(long)
                };

                obj = JsonConvert.DeserializeAnonymousType(json, obj);
                tmp.Data.Add(obj.Data);
                tmp.timestamp = obj.Timestamp;
            }

            return tmp;
        }
    }
}
