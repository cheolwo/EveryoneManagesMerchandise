using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeePlatMarketService : MarketService, IDTOService<EmployeePlatMarket>
    {
        public EmployeePlatMarketService(MarketServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeePlatMarket/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeePlatMarket?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeePlatMarket>($"/api/EmployeePlatMarket/{id}");
        }

        public async Task<IEnumerable<EmployeePlatMarket>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeePlatMarket>>("/api/EmployeePlatMarket");
        }

        public async Task<EmployeePlatMarket?> PostAsync(EmployeePlatMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeePlatMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeePlatMarket = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeePlatMarket? EmployeePlatMarket = JsonSerializer.Deserialize<EmployeePlatMarket>(JsonEmployeePlatMarket);
            return EmployeePlatMarket;
        }

        public async Task<EmployeePlatMarket?> PutAsync(EmployeePlatMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeePlatMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeePlatMarket = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeePlatMarket? EmployeePlatMarket = JsonSerializer.Deserialize<EmployeePlatMarket>(JsonEmployeePlatMarket);

            return EmployeePlatMarket;
        }
    }
}
