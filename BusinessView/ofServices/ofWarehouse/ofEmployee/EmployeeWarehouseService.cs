using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeWarehouseService : WarehouseService, IDTOService<EmployeeWarehouse>
    {
        public EmployeeWarehouseService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeWarehouse/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeWarehouse?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeWarehouse>($"/api/EmployeeWarehouse/{id}");
        }

        public async Task<IEnumerable<EmployeeWarehouse>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeWarehouse>>("/api/EmployeeWarehouse");
        }

        public async Task<EmployeeWarehouse?> PostAsync(EmployeeWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeWarehouse", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeWarehouse = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeWarehouse? EmployeeWarehouse = JsonSerializer.Deserialize<EmployeeWarehouse>(JsonEmployeeWarehouse);
            return EmployeeWarehouse;
        }

        public async Task<EmployeeWarehouse?> PutAsync(EmployeeWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeWarehouse", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeWarehouse = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeWarehouse? EmployeeWarehouse = JsonSerializer.Deserialize<EmployeeWarehouse>(JsonEmployeeWarehouse);

            return EmployeeWarehouse;
        }
    }
}
