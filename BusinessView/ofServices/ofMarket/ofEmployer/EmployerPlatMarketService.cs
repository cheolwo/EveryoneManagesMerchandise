using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofMarket.ofEmployer
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

        public async Task<EmployerPlatMarket?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerPlatMarket>($"/api/EmployerPlatMarket/{id}");
        }

        public async Task<IEnumerable<EmployerPlatMarket>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerPlatMarket>>("/api/EmployerPlatMarket");
        }

        public async Task PostAsync(EmployerPlatMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerPlatMarket", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerPlatMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerPlatMarket", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
