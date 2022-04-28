using BusinessView.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofEmployee
{
    public class EmployeeLoadFrameService : WarehouseService, IDTOService<EmployeeLoadFrame>
    {
        public EmployeeLoadFrameService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeLoadFrame/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeLoadFrame?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeLoadFrame>($"/api/EmployeeLoadFrame/{id}");
        }

        public async Task<IEnumerable<EmployeeLoadFrame>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeLoadFrame>>("/api/EmployeeLoadFrame");
        }

        public async Task PostAsync(EmployeeLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeLoadFrame", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeLoadFrame", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
