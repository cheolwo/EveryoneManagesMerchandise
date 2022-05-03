using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformSWCommodityService : WarehouseService, IDTOService<PlatformSWCommodity>
    {
        public PlatformSWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformSWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformSWCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformSWCommodity>($"/api/PlatformSWCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformSWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformSWCommodity>>("/api/PlatformSWCommodity");
        }

        public async Task<PlatformSWCommodity?> PostAsync(PlatformSWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformSWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformSWCommodity? PlatformSWCommodity = JsonSerializer.Deserialize<PlatformSWCommodity>(JsonPlatformSWCommodity);
            return PlatformSWCommodity;
        }

        public async Task<PlatformSWCommodity?> PutAsync(PlatformSWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformSWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformSWCommodity? PlatformSWCommodity = JsonSerializer.Deserialize<PlatformSWCommodity>(JsonPlatformSWCommodity);

            return PlatformSWCommodity;
        }
    }
}
