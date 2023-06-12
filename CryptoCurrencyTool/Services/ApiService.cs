using CryptoCurrencyTool.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;


namespace CryptoCurrencyTool.Services
{
    public class ApiService
    {
        public static async Task<List<CryptoCurrency>> GetAssetsDataAsync(string id = "")
        {
            List<CryptoCurrency>? result = null;
            
            var content = await ConnectingService.GetDataAsync("assets/" + id); 
            if (content == null) return null;

            var json = JObject.Parse(content);
            var data = id == "" ? json["data"].Value<JArray>() : new JArray(json["data"]);

            result = data.ToObject<List<CryptoCurrency>>();
            
            return result;
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
            history.Currency = (await GetAssetsDataAsync(id))[0];

            return history;
        }

        //api.coincap.io/v2/assets/bitcoin/markets?limit=5&offset=0
        public static async Task<List<Market>> GetMarketDataAsync(string id, int limit = 0, int offset = 0)
        {
            var url = "assets/" + id + "/markets/";
            if (limit != 0 && offset != 0)
                url += "?limit=" + limit;
            else if (limit != 0)
                url += "?limit=" + limit;
            else if (offset != 0)
                url += "?offset=" + offset;


            List<Market>? result = null;
            
            var content = await ConnectingService.GetDataAsync(url);
            if (content == null) return null;

            var json = JObject.Parse(content);
            var data = id == "" ? json["data"].Value<JArray>() : new JArray(json["data"]);

            result = data.ToObject<List<Market>>();
            
            return result;
        }

        //api.coincap.io/v2/rates/bitcoin
        public static async Task<List<RateItem>> GetRateDataAsync(string id = "")
        {
            List<RateItem>? result = null;

            var content = await ConnectingService.GetDataAsync("rates/" + id);
            if (content == null) return null;

            var json = JObject.Parse(content);
            var data = id == "" ? json["data"].Value<JArray>() : new JArray(json["data"]);

            result = data.ToObject<List<RateItem>>();

            return result;
        }
    }
}
