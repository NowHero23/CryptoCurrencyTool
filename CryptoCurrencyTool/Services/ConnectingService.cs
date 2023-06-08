using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.Services
{
    public class ConnectingService
    {
        public static readonly string defaultApiUrl = "http://api.coincap.io/v2/"; // URL API

        public static async Task<string> GetCurrency(string apiUrl)
        {
            HttpClient client = new HttpClient();
            string json = "";
            try
            {
                HttpResponseMessage httpResponse = await client.GetAsync(apiUrl);
                json = await httpResponse.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            finally
            {
                client.Dispose();
            }

            return json;
        }

    }
}
