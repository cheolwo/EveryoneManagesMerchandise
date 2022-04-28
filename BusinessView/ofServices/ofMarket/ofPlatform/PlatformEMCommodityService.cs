using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofMarket.ofPlatform;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofMarket.ofPlatform
{
    public class PlatformEMCommodityService : MarketService, IDTOService<PlatformEMCommodity>
    {
        public PlatformEMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformEMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformEMCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformEMCommodity>($"/api/PlatformEMCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformEMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformEMCommodity>>("/api/PlatformEMCommodity");
        }

        public async Task PostAsync(PlatformEMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformEMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformEMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformEMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
