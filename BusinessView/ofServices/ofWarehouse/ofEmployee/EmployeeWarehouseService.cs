using BusinessView.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofEmployee
{
    public class EmployeeWarehouseService : WarehouseService, IDTOService<EmployeeWarehouse>
    {
        public EmployeeWarehouseService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeWarehouse/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeWarehouse?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeWarehouse>($"/api/EmployeeWarehouse/{id}");
        }

        public async Task<IEnumerable<EmployeeWarehouse>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeWarehouse>>("/api/EmployeeWarehouse");
        }

        public async Task PostAsync(EmployeeWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeWarehouse", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeWarehouse", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
