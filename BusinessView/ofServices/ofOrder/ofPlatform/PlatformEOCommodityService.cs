using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofOrder.ofPlatform
{
    public class PlatformEOCommodityService : OrderService, IDTOService<PlatformEOCommodity>
    {
        public PlatformEOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformEOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformEOCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformEOCommodity>($"/api/PlatformEOCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformEOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformEOCommodity>>("/api/PlatformEOCommodity");
        }

        public async Task PostAsync(PlatformEOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformEOCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformEOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformEOCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
