using BusinessView.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofEmployee
{
    public class EmployeeWorkingDeskService : WarehouseService, IDTOService<EmployeeWorkingDesk>
    {
        public EmployeeWorkingDeskService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeWorkingDesk/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeWorkingDesk?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeWorkingDesk>($"/api/EmployeeWorkingDesk/{id}");
        }

        public async Task<IEnumerable<EmployeeWorkingDesk>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeWorkingDesk>>("/api/EmployeeWorkingDesk");
        }

        public async Task PostAsync(EmployeeWorkingDesk entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeWorkingDesk", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeWorkingDesk entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeWorkingDesk", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
