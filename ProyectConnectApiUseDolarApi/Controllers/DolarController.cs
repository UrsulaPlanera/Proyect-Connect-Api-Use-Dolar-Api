using Microsoft.AspNetCore.Mvc;
using ProyectConnectApiUseDolarApi.Models;
using System.Net.Http.Headers;
using System.Text.Json;

namespace ProyectConnectApiUseDolarApi.Controllers
{
    public class DolarController : Controller
    {
        private readonly HttpClient _httpClient;

        public DolarController(IHttpClientFactory httpClientFactory)
        {
            _httpClient = httpClientFactory.CreateClient();
            _httpClient.BaseAddress = new Uri("https://dolarapi.com");
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        [HttpGet]
        public async Task<IActionResult> Inicio()
        {
            var respuesta = await _httpClient.GetAsync("/v1/dolares");
            if(respuesta.IsSuccessStatusCode)
            {
                var dolar = await respuesta.Content.ReadAsAsync<List<Dolar>>();
                return View(dolar);
            }
            else
            {
                return View("Error");
            }
        }
    }
}
