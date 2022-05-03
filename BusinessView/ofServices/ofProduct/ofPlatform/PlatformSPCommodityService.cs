using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformSPCommodityService : ProductService, IDTOService<PlatformSPCommodity>
    {
        public PlatformSPCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformSPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformSPCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformSPCommodity>($"/api/PlatformSPCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformSPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformSPCommodity>>("/api/PlatformSPCommodity");
        }

        public async Task<PlatformSPCommodity?> PostAsync(PlatformSPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformSPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformSPCommodity? PlatformSPCommodity = JsonSerializer.Deserialize<PlatformSPCommodity>(JsonPlatformSPCommodity);
            return PlatformSPCommodity;
        }

        public async Task<PlatformSPCommodity?> PutAsync(PlatformSPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformSPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformSPCommodity? PlatformSPCommodity = JsonSerializer.Deserialize<PlatformSPCommodity>(JsonPlatformSPCommodity);

            return PlatformSPCommodity;
        }
    }
}
