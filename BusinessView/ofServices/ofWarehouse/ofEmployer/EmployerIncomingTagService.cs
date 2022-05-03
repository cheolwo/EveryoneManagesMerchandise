using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerIncomingTagService : WarehouseService, IDTOService<EmployerIncomingTag>
    {
        public EmployerIncomingTagService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerIncomingTag/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerIncomingTag?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerIncomingTag>($"/api/EmployerIncomingTag/{id}");
        }

        public async Task<IEnumerable<EmployerIncomingTag>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerIncomingTag>>("/api/EmployerIncomingTag");
        }

        public async Task<EmployerIncomingTag?> PostAsync(EmployerIncomingTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerIncomingTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerIncomingTag = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerIncomingTag? EmployerIncomingTag = JsonSerializer.Deserialize<EmployerIncomingTag>(JsonEmployerIncomingTag);
            return EmployerIncomingTag;
        }

        public async Task<EmployerIncomingTag?> PutAsync(EmployerIncomingTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerIncomingTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerIncomingTag = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerIncomingTag? EmployerIncomingTag = JsonSerializer.Deserialize<EmployerIncomingTag>(JsonEmployerIncomingTag);

            return EmployerIncomingTag;
        }
    }
}
