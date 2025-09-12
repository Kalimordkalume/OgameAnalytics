using System.Text.Json;
using OgameAnalytics.Frontend.Models;

namespace OgameAnalytics.Frontend.Services
{
    public class BuildingCostApiService
    {

        private readonly HttpClient _httpClient;


        public BuildingCostApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }



        public async Task<CalculateBuildingUpgradeCostResponse?> CalculateUpgradeCostAsync(CalculateBuildingUpgradeCostRequest request)
        {
            var response = await _httpClient.PostAsJsonAsync("api/use-cases/buildings/calculate-upgrade-cost", request);

            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine("API Response: " + content);
            return JsonSerializer.Deserialize<CalculateBuildingUpgradeCostResponse>(
                content,
                new JsonSerializerOptions { PropertyNameCaseInsensitive = true }
            );
        }

    }
}
