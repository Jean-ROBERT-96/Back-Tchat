using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using Tchat.interfaces;

namespace Tchat.data
{
    public class DataConnect<T> : IDataConnect<T>
    { 
        private const string url = "http://tchatapi.fr:82/api/";
        private HttpClient client;

        public async Task<ICollection<T>> GetListConnect(string controller)
        {
            using(client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var response = await client.GetAsync(controller);

                var data = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<ICollection<T>>(data).ToList();
            }
        }

        public async Task<bool> PostConnect(string controller, T obj)
        {
            using(client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

                var send = await client.PostAsync(controller, content);
                if(send.IsSuccessStatusCode)
                    return true;

                return false;
            }
        }

        public async Task<bool> PutConnect(string controllerId, T obj)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                var content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");

                var edit = await client.PutAsync(controllerId, content);
                if (edit.IsSuccessStatusCode)
                    return true;

                return false;
            }
        }

        public async Task<bool> DeleteConnect(string controllerId)
        {
            using (client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                var del = await client.DeleteAsync(controllerId);
                if (del.IsSuccessStatusCode)
                    return true;

                return false;
            }
        }
    }
}
