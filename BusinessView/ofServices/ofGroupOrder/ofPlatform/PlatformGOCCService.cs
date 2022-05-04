using BusinessView.ofDTO.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform
{
    public class PlatformGOCCService : GroupOrderService, IDTOService<PlatformGOCC>
    {
        public PlatformGOCCService(GroupOrderServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformGOCC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformGOCC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformGOCC>($"/api/PlatformGOCC/{id}");
        }

        public async Task<IEnumerable<PlatformGOCC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformGOCC>>("/api/PlatformGOCC");
        }

        public async Task<PlatformGOCC?> PostAsync(PlatformGOCC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformGOCC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformGOCC = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformGOCC? PlatformGOCC = JsonSerializer.Deserialize<PlatformGOCC>(JsonPlatformGOCC);
            return PlatformGOCC;
        }

        public async Task<PlatformGOCC?> PutAsync(PlatformGOCC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformGOCC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformGOCC = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformGOCC? PlatformGOCC = JsonSerializer.Deserialize<PlatformGOCC>(JsonPlatformGOCC);

            return PlatformGOCC;
        }
    }
}
