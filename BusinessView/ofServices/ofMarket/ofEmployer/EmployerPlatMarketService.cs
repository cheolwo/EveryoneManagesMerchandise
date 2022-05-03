using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerPlatMarketService : MarketService, IDTOService<EmployerPlatMarket>
    {
        public EmployerPlatMarketService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerPlatMarket/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerPlatMarket?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerPlatMarket>($"/api/EmployerPlatMarket/{id}");
        }

        public async Task<IEnumerable<EmployerPlatMarket>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerPlatMarket>>("/api/EmployerPlatMarket");
        }

        public async Task<EmployerPlatMarket?> PostAsync(EmployerPlatMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerPlatMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerPlatMarket = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerPlatMarket? EmployerPlatMarket = JsonSerializer.Deserialize<EmployerPlatMarket>(JsonEmployerPlatMarket);
            return EmployerPlatMarket;
        }

        public async Task<EmployerPlatMarket?> PutAsync(EmployerPlatMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerPlatMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerPlatMarket = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerPlatMarket? EmployerPlatMarket = JsonSerializer.Deserialize<EmployerPlatMarket>(JsonEmployerPlatMarket);

            return EmployerPlatMarket;
        }
    }
}
