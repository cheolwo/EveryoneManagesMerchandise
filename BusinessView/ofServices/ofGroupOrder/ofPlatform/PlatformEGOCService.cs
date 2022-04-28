using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofGroupOrder.ofPlatform;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofPlatform
{
    public class PlatformEGOCService : GroupOrderService, IDTOService<PlatformEGOC>
    {
        public PlatformEGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformEGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformEGOC?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformEGOC>($"/api/PlatformEGOC/{id}");
        }

        public async Task<IEnumerable<PlatformEGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformEGOC>>("/api/PlatformEGOC");
        }

        public async Task PostAsync(PlatformEGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformEGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformEGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformEGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
