using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHttpClient
{
    public class ConsumoApis
    {
        private readonly HttpClient _client;
        private readonly string _basePath;

        public ConsumoApis(string basePath)
        {
            _client = new HttpClient();
            _basePath = basePath;
        }

        /******/
        /******/
        /******/

        public async Task<List<Cliente>> FiltrarAsync()
        {
            List<Cliente>? list = null;
            try
            {
                HttpResponseMessage response = await _client.GetAsync(_basePath);
                if (response.IsSuccessStatusCode)
                {
                    list = await response.Content.ReadFromJsonAsync<List<Cliente>>();
                }

            }catch (Exception ex)
            {
                Console.WriteLine("Error con la API: " + ex.Message);
            }
            return list;
        }

        /******/
        /******/
        /******/

        public async Task<bool> ModificarCliente(Cliente cliente)
        { 
            HttpResponseMessage response = await _client.PutAsJsonAsync(_basePath,cliente);
            response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;

        }

        public async Task<bool> AltaCliente(Cliente cliente)
        {
            HttpResponseMessage response = await _client.PostAsJsonAsync(_basePath, cliente);
            
            response.EnsureSuccessStatusCode();

            return response.IsSuccessStatusCode;

        }
        public async Task<bool> EliminarCliente(int id)
        {
            try
            {

                HttpRequestMessage request = new HttpRequestMessage
                {
                    Method = HttpMethod.Delete,
                    Content= JsonContent.Create(id),
                    RequestUri = new Uri(_basePath,UriKind.Absolute)
                };

                HttpResponseMessage response = await _client.SendAsync(request);
                response.EnsureSuccessStatusCode();

                if(response.StatusCode == HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                return false;
            }
        
        }

    }
}
