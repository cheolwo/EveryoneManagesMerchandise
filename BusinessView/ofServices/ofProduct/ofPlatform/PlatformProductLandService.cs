using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofProduct.ofPlatform
{
    public class PlatformProductLandService : ProductService, IDTOService<PlatformProductLand>
    {
        public PlatformProductLandService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformProductLand/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformProductLand?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformProductLand>($"/api/PlatformProductLand/{id}");
        }

        public async Task<IEnumerable<PlatformProductLand>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformProductLand>>("/api/PlatformProductLand");
        }

        public async Task PostAsync(PlatformProductLand entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformProductLand", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformProductLand entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformProductLand", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
