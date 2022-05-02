using BusinessView.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeIncomingTagService : WarehouseService, IDTOService<EmployeeIncomingTag>
    {
        public EmployeeIncomingTagService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeIncomingTag/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeIncomingTag?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeIncomingTag>($"/api/EmployeeIncomingTag/{id}");
        }

        public async Task<IEnumerable<EmployeeIncomingTag>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeIncomingTag>>("/api/EmployeeIncomingTag");
        }

        public async Task<EmployeeIncomingTag?> PostAsync(EmployeeIncomingTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeIncomingTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeIncomingTag = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeIncomingTag? EmployeeIncomingTag = JsonSerializer.Deserialize<EmployeeIncomingTag>(JsonEmployeeIncomingTag);
            return EmployeeIncomingTag;
        }

        public async Task<EmployeeIncomingTag?> PutAsync(EmployeeIncomingTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeIncomingTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeIncomingTag = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeIncomingTag? EmployeeIncomingTag = JsonSerializer.Deserialize<EmployeeIncomingTag>(JsonEmployeeIncomingTag);

            return EmployeeIncomingTag;
        }
    }
}
