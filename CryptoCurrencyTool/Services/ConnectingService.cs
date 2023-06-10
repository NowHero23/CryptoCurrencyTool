using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CryptoCurrencyTool.Services
{
    public class ConnectingService
    {
        private static readonly string defaultApiUrl = "http://api.coincap.io/v2/"; // URL API

        public static async Task<string> GetDataAsync(string path)
        {
            string result = null;
            
            try
            {
                using (var client = new HttpClient())
                {
                    // Setting Base address.  
                    client.BaseAddress = new Uri(defaultApiUrl);

                    // Setting content type.  
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    // Initialization.  
                    HttpResponseMessage response = new HttpResponseMessage();

                    // HTTP GET  
                    response = await client.GetAsync(path).ConfigureAwait(false);

                    // Verification  
                    if (response.IsSuccessStatusCode)
                    {
                        // Reading Response.  
                        result = response.Content.ReadAsStringAsync().Result;
                    }
                }
            }
            catch (System.Net.Http.HttpRequestException httpRequestException) //No internet
            {
                return null;
                
            }
            

            return result;
        }

    }
}
