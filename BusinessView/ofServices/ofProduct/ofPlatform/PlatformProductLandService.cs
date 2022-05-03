using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
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

        public async Task<PlatformProductLand?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformProductLand>($"/api/PlatformProductLand/{id}");
        }

        public async Task<IEnumerable<PlatformProductLand>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformProductLand>>("/api/PlatformProductLand");
        }

        public async Task<PlatformProductLand?> PostAsync(PlatformProductLand entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformProductLand", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformProductLand = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformProductLand? PlatformProductLand = JsonSerializer.Deserialize<PlatformProductLand>(JsonPlatformProductLand);
            return PlatformProductLand;
        }

        public async Task<PlatformProductLand?> PutAsync(PlatformProductLand entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformProductLand", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformProductLand = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformProductLand? PlatformProductLand = JsonSerializer.Deserialize<PlatformProductLand>(JsonPlatformProductLand);

            return PlatformProductLand;
        }
    }
}
