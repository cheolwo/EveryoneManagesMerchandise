using BusinessView.ofDTO.ofProduct.ofPlatform;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformProductCenterService : ProductService, IDTOService<PlatformProductCenter>
    {
        public PlatformProductCenterService(ProductServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformProductCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformProductCenter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformProductCenter>($"/api/PlatformProductCenter/{id}");
        }

        public async Task<IEnumerable<PlatformProductCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformProductCenter>>("/api/PlatformProductCenter");
        }

        public async Task<PlatformProductCenter?> PostAsync(PlatformProductCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformProductCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformProductCenter = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformProductCenter? PlatformProductCenter = JsonSerializer.Deserialize<PlatformProductCenter>(JsonPlatformProductCenter);
            return PlatformProductCenter;
        }

        public async Task<PlatformProductCenter?> PutAsync(PlatformProductCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformProductCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformProductCenter = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformProductCenter? PlatformProductCenter = JsonSerializer.Deserialize<PlatformProductCenter>(JsonPlatformProductCenter);

            return PlatformProductCenter;
        }
    }
}
