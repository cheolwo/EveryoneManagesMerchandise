using BusinessView.ofDTO.ofJournalDTO.ofEmployer;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerJournalService : JournalService, IDTOService<EmployerJournal>
    {
        public EmployerJournalService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerJournal/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerJournal?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerJournal>($"/api/EmployerJournal/{id}");
        }

        public async Task<IEnumerable<EmployerJournal>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerJournal>>("/api/EmployerJournal");
        }

        public async Task PostAsync(EmployerJournal entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerJournal", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerJournal entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerJournal", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
