using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformTCommodityService : TradeService, IDTOService<PlatformTCommodity>
    {
        public PlatformTCommodityService(TradeServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformTCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformTCommodity>($"/api/PlatformTCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformTCommodity>>("/api/PlatformTCommodity");
        }

        public async Task<PlatformTCommodity?> PostAsync(PlatformTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformTCommodity? PlatformTCommodity = JsonSerializer.Deserialize<PlatformTCommodity>(JsonPlatformTCommodity);
            return PlatformTCommodity;
        }

        public async Task<PlatformTCommodity?> PutAsync(PlatformTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformTCommodity? PlatformTCommodity = JsonSerializer.Deserialize<PlatformTCommodity>(JsonPlatformTCommodity);

            return PlatformTCommodity;
        }
    }
}
