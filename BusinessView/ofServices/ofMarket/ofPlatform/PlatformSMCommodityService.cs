using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformSMCommodityService : MarketService, IDTOService<PlatformSMCommodity>
    {
        public PlatformSMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformSMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformSMCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformSMCommodity>($"/api/PlatformSMCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformSMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformSMCommodity>>("/api/PlatformSMCommodity");
        }

        public async Task<PlatformSMCommodity?> PostAsync(PlatformSMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformSMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformSMCommodity? PlatformSMCommodity = JsonSerializer.Deserialize<PlatformSMCommodity>(JsonPlatformSMCommodity);
            return PlatformSMCommodity;
        }

        public async Task<PlatformSMCommodity?> PutAsync(PlatformSMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformSMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformSMCommodity? PlatformSMCommodity = JsonSerializer.Deserialize<PlatformSMCommodity>(JsonPlatformSMCommodity);

            return PlatformSMCommodity;
        }
    }
}
