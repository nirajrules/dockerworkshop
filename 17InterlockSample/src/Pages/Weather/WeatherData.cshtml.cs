using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using WeatherWeb.Models;

namespace WeatherWeb.Pages.Weather
{
    public class WeatherDataModel : PageModel
    {
        private readonly WeatherWeb.Models.WeatherWebContext _context;

        public WeatherDataModel(WeatherWeb.Models.WeatherWebContext context)
        {
            _context = context;
        }

        public IList<WeatherData> WeatherData { get;set; }

        public async Task OnGetAsync()
        {
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://apiservice.kubernetes-dashboard.svc.cluster.local:32321/weatherforecast"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    WeatherData = JsonConvert.DeserializeObject<List<WeatherData>>(apiResponse);
                }
            }
        }
    }
}
