using PPAI_CU_5.Entidades;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;

namespace PPAI_CU_5.Interfacez
{
    public class InterfazApiBodega
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<List<VinoInfo>> ObtenerVinosDeBodegaSeleccionada(string nombreBodega)
        {
            List<VinoInfo> vinos = new List<VinoInfo>();
            try
            {
                string url = "http://localhost:3000/";
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
               
                List<VinoInfo> todosVinos = JsonConvert.DeserializeObject<List<VinoInfo>>(responseBody);
                vinos = todosVinos.FindAll(v => v.getBodega().Equals(nombreBodega, StringComparison.OrdinalIgnoreCase));
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine($"Request error: {e.Message}");
            }
            return vinos;
        }
    }
}
