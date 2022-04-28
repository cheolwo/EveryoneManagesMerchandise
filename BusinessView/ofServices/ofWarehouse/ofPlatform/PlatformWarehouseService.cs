using BusinessView.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofPlatform
{
    public class PlatformWarehouseService : WarehouseService, IDTOService<PlatformWarehouse>
    {
        public PlatformWarehouseService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformWarehouse/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformWarehouse?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformWarehouse>($"/api/PlatformWarehouse/{id}");
        }

        public async Task<IEnumerable<PlatformWarehouse>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformWarehouse>>("/api/PlatformWarehouse");
        }

        public async Task PostAsync(PlatformWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformWarehouse", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformWarehouse", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
