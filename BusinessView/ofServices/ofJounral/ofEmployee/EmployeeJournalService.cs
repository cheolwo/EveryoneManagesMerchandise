using BusinessView.ofDTO.ofJournalDTO.ofEmployee;
using BusinessView.ofServices.ofHR;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeJournalService : JournalService, IDTOService<EmployeeJournal>
    {
        public EmployeeJournalService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeJournal/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeJournal?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeJournal>($"/api/EmployeeJournal/{id}");
        }

        public async Task<IEnumerable<EmployeeJournal>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeJournal>>("/api/EmployeeJournal");
        }

        public async Task PostAsync(EmployeeJournal entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeJournal", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeJournal entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeJournal", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
