using BusinessView.ofDTO.ofOrder.ofPlatform;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformOCommodityService : OrderService, IDTOService<PlatformOCommodity>
    {
        public PlatformOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformOCommodity>($"/api/PlatformOCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformOCommodity>>("/api/PlatformOCommodity");
        }

        public async Task<PlatformOCommodity?> PostAsync(PlatformOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformOCommodity? PlatformOCommodity = JsonSerializer.Deserialize<PlatformOCommodity>(JsonPlatformOCommodity);
            return PlatformOCommodity;
        }

        public async Task<PlatformOCommodity?> PutAsync(PlatformOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformOCommodity? PlatformOCommodity = JsonSerializer.Deserialize<PlatformOCommodity>(JsonPlatformOCommodity);

            return PlatformOCommodity;
        }
    }
}
