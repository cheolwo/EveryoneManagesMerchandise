using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform
{
    public class PlatformGOCCService : GroupOrderService, IDTOService<PlatformGOCC>
    {
        public PlatformGOCCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformGOCC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformGOCC?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformGOCC>($"/api/PlatformGOCC/{id}");
        }

        public async Task<IEnumerable<PlatformGOCC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformGOCC>>("/api/PlatformGOCC");
        }

        public async Task PostAsync(PlatformGOCC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformGOCC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformGOCC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformGOCC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
