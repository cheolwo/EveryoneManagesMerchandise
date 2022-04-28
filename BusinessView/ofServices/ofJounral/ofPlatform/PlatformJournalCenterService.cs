using BusinessView.ofDTO.ofJournalDTO.ofPlatform;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformJournalCenterService : JournalService, IDTOService<PlatformJournalCenter>
    {
        public PlatformJournalCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformJournalCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformJournalCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformJournalCenter>($"/api/PlatformJournalCenter/{id}");
        }

        public async Task<IEnumerable<PlatformJournalCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformJournalCenter>>("/api/PlatformJournalCenter");
        }

        public async Task PostAsync(PlatformJournalCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformJournalCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformJournalCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformJournalCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
