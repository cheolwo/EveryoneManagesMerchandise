using BusinessView.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofPlatform
{
    public class PlatformWorkingDeskService : WarehouseService, IDTOService<PlatformWorkingDesk>
    {
        public PlatformWorkingDeskService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformWorkingDesk/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformWorkingDesk?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformWorkingDesk>($"/api/PlatformWorkingDesk/{id}");
        }

        public async Task<IEnumerable<PlatformWorkingDesk>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformWorkingDesk>>("/api/PlatformWorkingDesk");
        }

        public async Task PostAsync(PlatformWorkingDesk entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformWorkingDesk", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformWorkingDesk entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformWorkingDesk", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
