using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofMarket.ofEmployee
{
    public class EmployeeMarketService : MarketService, IDTOService<EmployeeMarket>
    {
        public EmployeeMarketService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeMarket/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeMarket?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMarket>($"/api/EmployeeMarket/{id}");
        }

        public async Task<IEnumerable<EmployeeMarket>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMarket>>("/api/EmployeeMarket");
        }

        public async Task PostAsync(EmployeeMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMarket", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMarket", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
