using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformMCommodityService : MarketService, IDTOService<PlatformMCommodity>
    {
        public PlatformMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformMCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformMCommodity>($"/api/PlatformMCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformMCommodity>>("/api/PlatformMCommodity");
        }

        public async Task<PlatformMCommodity?> PostAsync(PlatformMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformMCommodity? PlatformMCommodity = JsonSerializer.Deserialize<PlatformMCommodity>(JsonPlatformMCommodity);
            return PlatformMCommodity;
        }

        public async Task<PlatformMCommodity?> PutAsync(PlatformMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformMCommodity? PlatformMCommodity = JsonSerializer.Deserialize<PlatformMCommodity>(JsonPlatformMCommodity);

            return PlatformMCommodity;
        }
    }
}
