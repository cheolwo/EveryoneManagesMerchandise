using BusinessView.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformProducterService : ProductService, IDTOService<PlatformProducter>
    {
        public PlatformProducterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformProducter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformProducter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformProducter>($"/api/PlatformProducter/{id}");
        }

        public async Task<IEnumerable<PlatformProducter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformProducter>>("/api/PlatformProducter");
        }

        public async Task<PlatformProducter?> PostAsync(PlatformProducter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformProducter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformProducter = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformProducter? PlatformProducter = JsonSerializer.Deserialize<PlatformProducter>(JsonPlatformProducter);
            return PlatformProducter;
        }

        public async Task<PlatformProducter?> PutAsync(PlatformProducter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformProducter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformProducter = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformProducter? PlatformProducter = JsonSerializer.Deserialize<PlatformProducter>(JsonPlatformProducter);

            return PlatformProducter;
        }
    }
}
