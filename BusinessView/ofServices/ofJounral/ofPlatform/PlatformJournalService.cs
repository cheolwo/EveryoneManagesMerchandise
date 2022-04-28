using BusinessView.ofDTO.ofJournalDTO.ofPlatform;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformJournalService : JournalService, IDTOService<PlatformJournal>
    {
        public PlatformJournalService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformJournal/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformJournal?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformJournal>($"/api/PlatformJournal/{id}");
        }

        public async Task<IEnumerable<PlatformJournal>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformJournal>>("/api/PlatformJournal");
        }

        public async Task PostAsync(PlatformJournal entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformJournal", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformJournal entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformJournal", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
