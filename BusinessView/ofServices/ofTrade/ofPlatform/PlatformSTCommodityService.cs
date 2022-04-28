using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofTrade.ofPlatform
{
    public class PlatformSTCommodityService : TradeService, IDTOService<PlatformSTCommodity>
    {
        public PlatformSTCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformSTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformSTCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformSTCommodity>($"/api/PlatformSTCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformSTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformSTCommodity>>("/api/PlatformSTCommodity");
        }

        public async Task PostAsync(PlatformSTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformSTCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformSTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformSTCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
