using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformEWCommodityService : WarehouseService, IDTOService<PlatformEWCommodity>
    {
        public PlatformEWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformEWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformEWCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformEWCommodity>($"/api/PlatformEWCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformEWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformEWCommodity>>("/api/PlatformEWCommodity");
        }

        public async Task<PlatformEWCommodity?> PostAsync(PlatformEWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformEWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformEWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformEWCommodity? PlatformEWCommodity = JsonSerializer.Deserialize<PlatformEWCommodity>(JsonPlatformEWCommodity);
            return PlatformEWCommodity;
        }

        public async Task<PlatformEWCommodity?> PutAsync(PlatformEWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformEWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformEWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformEWCommodity? PlatformEWCommodity = JsonSerializer.Deserialize<PlatformEWCommodity>(JsonPlatformEWCommodity);

            return PlatformEWCommodity;
        }
    }
}
