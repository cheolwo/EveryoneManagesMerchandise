using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformMOCommodityService : OrderService, IDTOService<PlatformMOCommodity>
    {
        public PlatformMOCommodityService(OrderServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformMOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformMOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformMOCommodity>($"/api/PlatformMOCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformMOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformMOCommodity>>("/api/PlatformMOCommodity");
        }

        public async Task<PlatformMOCommodity?> PostAsync(PlatformMOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformMOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformMOCommodity? PlatformMOCommodity = JsonSerializer.Deserialize<PlatformMOCommodity>(JsonPlatformMOCommodity);
            return PlatformMOCommodity;
        }

        public async Task<PlatformMOCommodity?> PutAsync(PlatformMOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformMOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformMOCommodity? PlatformMOCommodity = JsonSerializer.Deserialize<PlatformMOCommodity>(JsonPlatformMOCommodity);

            return PlatformMOCommodity;
        }
    }
}
