using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
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

        public async Task<EmployeeMarket?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMarket>($"/api/EmployeeMarket/{id}");
        }

        public async Task<IEnumerable<EmployeeMarket>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMarket>>("/api/EmployeeMarket");
        }

        public async Task<EmployeeMarket?> PostAsync(EmployeeMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMarket = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeMarket? EmployeeMarket = JsonSerializer.Deserialize<EmployeeMarket>(JsonEmployeeMarket);
            return EmployeeMarket;
        }

        public async Task<EmployeeMarket?> PutAsync(EmployeeMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMarket = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeMarket? EmployeeMarket = JsonSerializer.Deserialize<EmployeeMarket>(JsonEmployeeMarket);

            return EmployeeMarket;
        }
    }
}
