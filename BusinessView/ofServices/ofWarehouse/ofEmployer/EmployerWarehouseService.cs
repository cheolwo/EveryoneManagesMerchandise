using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerWarehouseService : WarehouseService, IDTOService<EmployerWarehouse>
    {
        public EmployerWarehouseService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerWarehouse/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerWarehouse?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerWarehouse>($"/api/EmployerWarehouse/{id}");
        }

        public async Task<IEnumerable<EmployerWarehouse>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerWarehouse>>("/api/EmployerWarehouse");
        }

        public async Task<EmployerWarehouse?> PostAsync(EmployerWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerWarehouse", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerWarehouse = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerWarehouse? EmployerWarehouse = JsonSerializer.Deserialize<EmployerWarehouse>(JsonEmployerWarehouse);
            return EmployerWarehouse;
        }

        public async Task<EmployerWarehouse?> PutAsync(EmployerWarehouse entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerWarehouse", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerWarehouse = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerWarehouse? EmployerWarehouse = JsonSerializer.Deserialize<EmployerWarehouse>(JsonEmployerWarehouse);

            return EmployerWarehouse;
        }
    }
}
