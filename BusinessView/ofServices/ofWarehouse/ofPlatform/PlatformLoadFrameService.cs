using BusinessView.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofPlatform
{
    public class PlatformLoadFrameService : WarehouseService, IDTOService<PlatformLoadFrame>
    {
        public PlatformLoadFrameService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformLoadFrame/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformLoadFrame?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformLoadFrame>($"/api/PlatformLoadFrame/{id}");
        }

        public async Task<IEnumerable<PlatformLoadFrame>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformLoadFrame>>("/api/PlatformLoadFrame");
        }

        public async Task PostAsync(PlatformLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformLoadFrame", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformLoadFrame", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
