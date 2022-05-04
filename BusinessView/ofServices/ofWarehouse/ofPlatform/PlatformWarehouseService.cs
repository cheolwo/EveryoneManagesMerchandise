using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformWarehouseService : WarehouseService, IDTOService<PlatformWarehouse>
    {
        public PlatformWarehouseService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformWarehouse/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformWarehouse?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformWarehouse>($"/api/PlatformWarehouse/{id}");
        }

        public async Task<IEnumerable<PlatformWarehouse>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformWarehouse>>("/api/PlatformWarehouse");
        }

        public async Task<PlatformWarehouse?> PostAsync(PlatformWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformWarehouse", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformWarehouse = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformWarehouse? PlatformWarehouse = JsonSerializer.Deserialize<PlatformWarehouse>(JsonPlatformWarehouse);
            return PlatformWarehouse;
        }

        public async Task<PlatformWarehouse?> PutAsync(PlatformWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformWarehouse", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformWarehouse = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformWarehouse? PlatformWarehouse = JsonSerializer.Deserialize<PlatformWarehouse>(JsonPlatformWarehouse);

            return PlatformWarehouse;
        }
    }
}
