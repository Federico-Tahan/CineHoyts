using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CineHoytsFront.Servicio
{
    public class ClaseSingleton
    {
        private static ClaseSingleton instancia;
        private HttpClient client;
        private ClaseSingleton()
        {
            client = new HttpClient();
        }
        public static ClaseSingleton GetInstance()
        {
            if (instancia == null)
                instancia = new ClaseSingleton();
            return instancia;
        }
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }


    }
}
