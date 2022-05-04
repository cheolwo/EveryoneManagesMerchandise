using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformLoadFrameService : WarehouseService, IDTOService<PlatformLoadFrame>
    {
        public PlatformLoadFrameService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformLoadFrame/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformLoadFrame?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformLoadFrame>($"/api/PlatformLoadFrame/{id}");
        }

        public async Task<IEnumerable<PlatformLoadFrame>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformLoadFrame>>("/api/PlatformLoadFrame");
        }

        public async Task<PlatformLoadFrame?> PostAsync(PlatformLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformLoadFrame", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformLoadFrame = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformLoadFrame? PlatformLoadFrame = JsonSerializer.Deserialize<PlatformLoadFrame>(JsonPlatformLoadFrame);
            return PlatformLoadFrame;
        }

        public async Task<PlatformLoadFrame?> PutAsync(PlatformLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformLoadFrame", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformLoadFrame = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformLoadFrame? PlatformLoadFrame = JsonSerializer.Deserialize<PlatformLoadFrame>(JsonPlatformLoadFrame);

            return PlatformLoadFrame;
        }
    }
}
