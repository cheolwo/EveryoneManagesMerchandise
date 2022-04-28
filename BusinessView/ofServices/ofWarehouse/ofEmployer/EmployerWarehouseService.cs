using BusinessView.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse
{
    public class EmployerWarehouseService : WarehouseService, IDTOService<EmployerWarehouse>
    {
        public EmployerWarehouseService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerWarehouse/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerWarehouse?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerWarehouse>($"/api/EmployerWarehouse/{id}");
        }

        public async Task<IEnumerable<EmployerWarehouse>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerWarehouse>>("/api/EmployerWarehouse");
        }

        public async Task PostAsync(EmployerWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerWarehouse", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerWarehouse", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
