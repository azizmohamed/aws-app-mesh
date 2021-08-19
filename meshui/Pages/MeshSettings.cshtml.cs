using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace meshui.Pages
{
    public class MeshSettingsModel: PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly HttpClient _httpClient;

        public MeshSettingsModel(ILogger<IndexModel> logger, HttpClient httpClient)
        {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task OnGet()
        {
            var response = await _httpClient.GetAsync("/settings");
            var content = await response.Content.ReadAsStringAsync();
            Color = JsonConvert.DeserializeObject<Settings>(content).Color;
        }

        public string Color { get; set; }
    }
}
