using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeJournalService : JournalService, IDTOService<EmployeeJournal>
    {
        public EmployeeJournalService(JournalServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeJournal/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeJournal?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeJournal>($"/api/EmployeeJournal/{id}");
        }

        public async Task<IEnumerable<EmployeeJournal>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeJournal>>("/api/EmployeeJournal");
        }

        public async Task<EmployeeJournal?> PostAsync(EmployeeJournal entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeJournal", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeJournal = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeJournal? EmployeeJournal = JsonSerializer.Deserialize<EmployeeJournal>(JsonEmployeeJournal);
            return EmployeeJournal;
        }

        public async Task<EmployeeJournal?> PutAsync(EmployeeJournal entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeJournal", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeJournal = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeJournal? EmployeeJournal = JsonSerializer.Deserialize<EmployeeJournal>(JsonEmployeeJournal);

            return EmployeeJournal;
        }
    }
}
