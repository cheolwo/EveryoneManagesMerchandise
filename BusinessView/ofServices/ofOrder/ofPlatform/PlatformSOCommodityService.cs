using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformSOCommodityService : OrderService, IDTOService<PlatformSOCommodity>
    {
        public PlatformSOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformSOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformSOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformSOCommodity>($"/api/PlatformSOCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformSOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformSOCommodity>>("/api/PlatformSOCommodity");
        }

        public async Task<PlatformSOCommodity?> PostAsync(PlatformSOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformSOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformSOCommodity? PlatformSOCommodity = JsonSerializer.Deserialize<PlatformSOCommodity>(JsonPlatformSOCommodity);
            return PlatformSOCommodity;
        }

        public async Task<PlatformSOCommodity?> PutAsync(PlatformSOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformSOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformSOCommodity? PlatformSOCommodity = JsonSerializer.Deserialize<PlatformSOCommodity>(JsonPlatformSOCommodity);

            return PlatformSOCommodity;
        }
    }
}
