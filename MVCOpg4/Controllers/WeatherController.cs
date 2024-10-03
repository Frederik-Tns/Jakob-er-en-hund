using Microsoft.AspNetCore.Mvc;
using MVCOpg4.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MVCOpg4.Controllers
{
    public class WeatherController : Controller
    {
        private readonly HttpClient _httpClient;

        public WeatherController(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string apiUrl = "https://localhost:7034/WeatherForecast"; 

            var response = await _httpClient.GetAsync(apiUrl);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                var weatherData = JsonConvert.DeserializeObject<List<WeatherForecast>>(jsonResponse);

                return View(weatherData);
            }

            return BadRequest();
        }
    }
}
