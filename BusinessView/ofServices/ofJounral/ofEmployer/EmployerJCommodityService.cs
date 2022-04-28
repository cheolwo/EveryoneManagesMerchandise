using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofDTO.ofJournalDTO.ofEmployee;
using BusinessView.ofDTO.ofJournalDTO.ofEmployer;
using BusinessView.ofServices.ofHR;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployer
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

        public async Task<EmployerJCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerJCommodity>($"/api/EmployerJCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerJCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerJCommodity>>("/api/EmployerJCommodity");
        }

        public async Task PostAsync(EmployerJCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerJCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerJCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerJCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
