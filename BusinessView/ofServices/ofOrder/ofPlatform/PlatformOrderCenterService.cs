using BusinessView.ofOrder.ofPlatform;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofOrder.ofPlatform
{
    public class PlatformOrderCenterService : OrderService, IDTOService<PlatformOrderCenter>
    {
        public PlatformOrderCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformOrderCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformOrderCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformOrderCenter>($"/api/PlatformOrderCenter/{id}");
        }

        public async Task<IEnumerable<PlatformOrderCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformOrderCenter>>("/api/PlatformOrderCenter");
        }

        public async Task PostAsync(PlatformOrderCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformOrderCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformOrderCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformOrderCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
