using BusinessView.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform
{
    public class PlatformSGOCService : GroupOrderService, IDTOService<PlatformSGOC>
    {
        public PlatformSGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformSGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformSGOC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformSGOC>($"/api/PlatformSGOC/{id}");
        }

        public async Task<IEnumerable<PlatformSGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformSGOC>>("/api/PlatformSGOC");
        }

        public async Task<PlatformSGOC?> PostAsync(PlatformSGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformSGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSGOC = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformSGOC? PlatformSGOC = JsonSerializer.Deserialize<PlatformSGOC>(JsonPlatformSGOC);
            return PlatformSGOC;
        }

        public async Task<PlatformSGOC?> PutAsync(PlatformSGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformSGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformSGOC = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformSGOC? PlatformSGOC = JsonSerializer.Deserialize<PlatformSGOC>(JsonPlatformSGOC);

            return PlatformSGOC;
        }
    }
}
