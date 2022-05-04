using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform
{
    public class PlatformMGOCService : GroupOrderService, IDTOService<PlatformMGOC>
    {
        public PlatformMGOCService(GroupOrderServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformMGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformMGOC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformMGOC>($"/api/PlatformMGOC/{id}");
        }

        public async Task<IEnumerable<PlatformMGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformMGOC>>("/api/PlatformMGOC");
        }

        public async Task<PlatformMGOC?> PostAsync(PlatformMGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformMGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMGOC = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformMGOC? PlatformMGOC = JsonSerializer.Deserialize<PlatformMGOC>(JsonPlatformMGOC);
            return PlatformMGOC;
        }

        public async Task<PlatformMGOC?> PutAsync(PlatformMGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformMGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformMGOC = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformMGOC? PlatformMGOC = JsonSerializer.Deserialize<PlatformMGOC>(JsonPlatformMGOC);

            return PlatformMGOC;
        }
    }
}
