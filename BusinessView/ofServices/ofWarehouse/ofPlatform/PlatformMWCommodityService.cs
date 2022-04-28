using BusinessView.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofPlatform
{
    public class PlatformMWCommodityService : WarehouseService, IDTOService<PlatformMWCommodity>
    {
        public PlatformMWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformMWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformMWCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformMWCommodity>($"/api/PlatformMWCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformMWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformMWCommodity>>("/api/PlatformMWCommodity");
        }

        public async Task PostAsync(PlatformMWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformMWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformMWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformMWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
