using BusinessView.ofDTO.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformWorkingDeskService : WarehouseService, IDTOService<PlatformWorkingDesk>
    {
        public PlatformWorkingDeskService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformWorkingDesk/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformWorkingDesk?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformWorkingDesk>($"/api/PlatformWorkingDesk/{id}");
        }

        public async Task<IEnumerable<PlatformWorkingDesk>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformWorkingDesk>>("/api/PlatformWorkingDesk");
        }

        public async Task<PlatformWorkingDesk?> PostAsync(PlatformWorkingDesk entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformWorkingDesk", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformWorkingDesk = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformWorkingDesk? PlatformWorkingDesk = JsonSerializer.Deserialize<PlatformWorkingDesk>(JsonPlatformWorkingDesk);
            return PlatformWorkingDesk;
        }

        public async Task<PlatformWorkingDesk?> PutAsync(PlatformWorkingDesk entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformWorkingDesk", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformWorkingDesk = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformWorkingDesk? PlatformWorkingDesk = JsonSerializer.Deserialize<PlatformWorkingDesk>(JsonPlatformWorkingDesk);

            return PlatformWorkingDesk;
        }
    }
}
