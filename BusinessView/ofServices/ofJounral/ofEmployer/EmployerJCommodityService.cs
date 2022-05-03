using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournalCenter.ofEmployee
{
    public class EmployerJCommodityService : JournalService, IDTOService<EmployerJCommodity>
    {
        public EmployerJCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerJCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerJCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerJCommodity>($"/api/EmployerJCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerJCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerJCommodity>>("/api/EmployerJCommodity");
        }

        public async Task<EmployerJCommodity?> PostAsync(EmployerJCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerJCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerJCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerJCommodity? EmployerJCommodity = JsonSerializer.Deserialize<EmployerJCommodity>(JsonEmployerJCommodity);
            return EmployerJCommodity;
        }

        public async Task<EmployerJCommodity?> PutAsync(EmployerJCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerJCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerJCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerJCommodity? EmployerJCommodity = JsonSerializer.Deserialize<EmployerJCommodity>(JsonEmployerJCommodity);

            return EmployerJCommodity;
        }
    }
}
