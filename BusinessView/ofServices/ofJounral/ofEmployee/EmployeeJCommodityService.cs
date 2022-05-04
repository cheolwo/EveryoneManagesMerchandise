using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeJCommodityService : JournalService, IDTOService<EmployeeJCommodity>
    {
        public EmployeeJCommodityService(JournalServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeJCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeJCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeJCommodity>($"/api/EmployeeJCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeJCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeJCommodity>>("/api/EmployeeJCommodity");
        }

        public async Task<EmployeeJCommodity?> PostAsync(EmployeeJCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeJCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeJCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeJCommodity? EmployeeJCommodity = JsonSerializer.Deserialize<EmployeeJCommodity>(JsonEmployeeJCommodity);
            return EmployeeJCommodity;
        }

        public async Task<EmployeeJCommodity?> PutAsync(EmployeeJCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeJCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeJCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeJCommodity? EmployeeJCommodity = JsonSerializer.Deserialize<EmployeeJCommodity>(JsonEmployeeJCommodity);

            return EmployeeJCommodity;
        }
    }
}
