using BusinessView.ofDTO.ofJournalDTO.ofEmployer;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerJournalCenterService : JournalService, IDTOService<EmployerJournalCenter>
    {
        public EmployerJournalCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerJournalCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerJournalCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerJournalCenter>($"/api/EmployerJournalCenter/{id}");
        }

        public async Task<IEnumerable<EmployerJournalCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerJournalCenter>>("/api/EmployerJournalCenter");
        }

        public async Task PostAsync(EmployerJournalCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerJournalCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerJournalCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerJournalCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
