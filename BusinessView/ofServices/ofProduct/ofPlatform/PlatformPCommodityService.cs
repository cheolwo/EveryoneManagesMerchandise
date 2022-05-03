using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformPCommodityService : ProductService, IDTOService<PlatformPCommodity>
    {
        public PlatformPCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformPCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformPCommodity>($"/api/PlatformPCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformPCommodity>>("/api/PlatformPCommodity");
        }

        public async Task<PlatformPCommodity?> PostAsync(PlatformPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformPCommodity? PlatformPCommodity = JsonSerializer.Deserialize<PlatformPCommodity>(JsonPlatformPCommodity);
            return PlatformPCommodity;
        }

        public async Task<PlatformPCommodity?> PutAsync(PlatformPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformPCommodity? PlatformPCommodity = JsonSerializer.Deserialize<PlatformPCommodity>(JsonPlatformPCommodity);

            return PlatformPCommodity;
        }
    }
}
