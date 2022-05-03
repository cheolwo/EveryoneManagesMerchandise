using BusinessView.ofDTO.ofMarket.ofPlatform;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformMMCommodityService : MarketService, IDTOService<PlatformMMCommodity>
    {
        public PlatformMMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformMMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformMMCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformMMCommodity>($"/api/PlatformMMCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformMMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformMMCommodity>>("/api/PlatformMMCommodity");
        }

        public async Task<PlatformMMCommodity?> PostAsync(PlatformMMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformMMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformMMCommodity? PlatformMMCommodity = JsonSerializer.Deserialize<PlatformMMCommodity>(JsonPlatformMMCommodity);
            return PlatformMMCommodity;
        }

        public async Task<PlatformMMCommodity?> PutAsync(PlatformMMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformMMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformMMCommodity? PlatformMMCommodity = JsonSerializer.Deserialize<PlatformMMCommodity>(JsonPlatformMMCommodity);

            return PlatformMMCommodity;
        }
    }
}
