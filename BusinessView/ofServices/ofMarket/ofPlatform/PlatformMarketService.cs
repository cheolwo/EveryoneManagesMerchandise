using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformMarketService : MarketService, IDTOService<PlatformMarket>
    {
        public PlatformMarketService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformMarket/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformMarket?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformMarket>($"/api/PlatformMarket/{id}");
        }

        public async Task<IEnumerable<PlatformMarket>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformMarket>>("/api/PlatformMarket");
        }

        public async Task<PlatformMarket?> PostAsync(PlatformMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMarket = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformMarket? PlatformMarket = JsonSerializer.Deserialize<PlatformMarket>(JsonPlatformMarket);
            return PlatformMarket;
        }

        public async Task<PlatformMarket?> PutAsync(PlatformMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMarket = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformMarket? PlatformMarket = JsonSerializer.Deserialize<PlatformMarket>(JsonPlatformMarket);

            return PlatformMarket;
        }
    }
}
