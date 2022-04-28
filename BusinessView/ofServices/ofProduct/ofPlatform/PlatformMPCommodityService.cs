using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofProduct.ofPlatform
{
    public class PlatformMPCommodityService : ProductService, IDTOService<PlatformMPCommodity>
    {
        public PlatformMPCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformMPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformMPCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformMPCommodity>($"/api/PlatformMPCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformMPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformMPCommodity>>("/api/PlatformMPCommodity");
        }

        public async Task PostAsync(PlatformMPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformMPCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformMPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformMPCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
