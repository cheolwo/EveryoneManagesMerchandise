using BusinessView.ofDTO.ofJournalDTO.ofEmployee;
using BusinessView.ofServices.ofHR;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeJournalCenterService : JournalService, IDTOService<EmployeeJournalCenter>
    {
        public EmployeeJournalCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeJournalCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeJournalCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeJournalCenter>($"/api/EmployeeJournalCenter/{id}");
        }

        public async Task<IEnumerable<EmployeeJournalCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeJournalCenter>>("/api/EmployeeJournalCenter");
        }

        public async Task PostAsync(EmployeeJournalCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeJournalCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeJournalCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeJournalCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
