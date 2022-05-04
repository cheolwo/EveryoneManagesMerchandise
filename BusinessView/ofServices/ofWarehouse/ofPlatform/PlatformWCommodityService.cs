using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformWCommodityService : WarehouseService, IDTOService<PlatformWCommodity>
    {
        public PlatformWCommodityService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformWCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformWCommodity>($"/api/PlatformWCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformWCommodity>>("/api/PlatformWCommodity");
        }

        public async Task<PlatformWCommodity?> PostAsync(PlatformWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformWCommodity? PlatformWCommodity = JsonSerializer.Deserialize<PlatformWCommodity>(JsonPlatformWCommodity);
            return PlatformWCommodity;
        }

        public async Task<PlatformWCommodity?> PutAsync(PlatformWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformWCommodity? PlatformWCommodity = JsonSerializer.Deserialize<PlatformWCommodity>(JsonPlatformWCommodity);

            return PlatformWCommodity;
        }
    }
}
