using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofMarket.ofPlatform
{
    public class PlatformPlatMarketService : MarketService, IDTOService<PlatformPlatMarket>
    {
        public PlatformPlatMarketService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformPlatMarket/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformPlatMarket?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformPlatMarket>($"/api/PlatformPlatMarket/{id}");
        }

        public async Task<IEnumerable<PlatformPlatMarket>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformPlatMarket>>("/api/PlatformPlatMarket");
        }

        public async Task PostAsync(PlatformPlatMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformPlatMarket", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformPlatMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformPlatMarket", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
