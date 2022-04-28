using BusinessView.ofDTO.ofJournalDTO.ofPlatform;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformJCommodityService : JournalService, IDTOService<PlatformJCommodity>
    {
        public PlatformJCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformJCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformJCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformJCommodity>($"/api/PlatformJCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformJCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformJCommodity>>("/api/PlatformJCommodity");
        }

        public async Task PostAsync(PlatformJCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformJCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformJCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformJCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
