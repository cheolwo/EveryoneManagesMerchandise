using BusinessView.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofPlatform
{
    public class PlatformDividedTagService : WarehouseService, IDTOService<PlatformDividedTag>
    {
        public PlatformDividedTagService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformDividedTag/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformDividedTag?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformDividedTag>($"/api/PlatformDividedTag/{id}");
        }

        public async Task<IEnumerable<PlatformDividedTag>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformDividedTag>>("/api/PlatformDividedTag");
        }

        public async Task PostAsync(PlatformDividedTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformDividedTag", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformDividedTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformDividedTag", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
