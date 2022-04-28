using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform
{
    public class PlatformGOCService : GroupOrderService, IDTOService<PlatformGOC>
    {
        public PlatformGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformGOC?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformGOC>($"/api/PlatformGOC/{id}");
        }

        public async Task<IEnumerable<PlatformGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformGOC>>("/api/PlatformGOC");
        }

        public async Task PostAsync(PlatformGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
