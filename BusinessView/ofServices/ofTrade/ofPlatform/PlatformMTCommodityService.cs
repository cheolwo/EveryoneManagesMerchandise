using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformMTCommodityService : TradeService, IDTOService<PlatformMTCommodity>
    {
        public PlatformMTCommodityService(TradeServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformMTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformMTCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformMTCommodity>($"/api/PlatformMTCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformMTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformMTCommodity>>("/api/PlatformMTCommodity");
        }

        public async Task<PlatformMTCommodity?> PostAsync(PlatformMTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformMTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformMTCommodity? PlatformMTCommodity = JsonSerializer.Deserialize<PlatformMTCommodity>(JsonPlatformMTCommodity);
            return PlatformMTCommodity;
        }

        public async Task<PlatformMTCommodity?> PutAsync(PlatformMTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformMTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformMTCommodity? PlatformMTCommodity = JsonSerializer.Deserialize<PlatformMTCommodity>(JsonPlatformMTCommodity);

            return PlatformMTCommodity;
        }
    }
}
