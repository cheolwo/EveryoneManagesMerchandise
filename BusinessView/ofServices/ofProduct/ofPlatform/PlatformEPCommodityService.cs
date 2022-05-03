using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformEPCommodityService : ProductService, IDTOService<PlatformEPCommodity>
    {
        public PlatformEPCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformEPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformEPCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformEPCommodity>($"/api/PlatformEPCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformEPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformEPCommodity>>("/api/PlatformEPCommodity");
        }

        public async Task<PlatformEPCommodity?> PostAsync(PlatformEPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformEPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformEPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformEPCommodity? PlatformEPCommodity = JsonSerializer.Deserialize<PlatformEPCommodity>(JsonPlatformEPCommodity);
            return PlatformEPCommodity;
        }

        public async Task<PlatformEPCommodity?> PutAsync(PlatformEPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformEPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformEPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformEPCommodity? PlatformEPCommodity = JsonSerializer.Deserialize<PlatformEPCommodity>(JsonPlatformEPCommodity);

            return PlatformEPCommodity;
        }
    }
}
