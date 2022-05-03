using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeDividedTagService : WarehouseService, IDTOService<EmployeeDividedTag>
    {
        public EmployeeDividedTagService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeDividedTag/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeDividedTag?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeDividedTag>($"/api/EmployeeDividedTag/{id}");
        }

        public async Task<IEnumerable<EmployeeDividedTag>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeDividedTag>>("/api/EmployeeDividedTag");
        }

        public async Task<EmployeeDividedTag?> PostAsync(EmployeeDividedTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeDividedTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeDividedTag = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeDividedTag? EmployeeDividedTag = JsonSerializer.Deserialize<EmployeeDividedTag>(JsonEmployeeDividedTag);
            return EmployeeDividedTag;
        }

        public async Task<EmployeeDividedTag?> PutAsync(EmployeeDividedTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeDividedTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeDividedTag = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeDividedTag? EmployeeDividedTag = JsonSerializer.Deserialize<EmployeeDividedTag>(JsonEmployeeDividedTag);

            return EmployeeDividedTag;
        }
    }
}
