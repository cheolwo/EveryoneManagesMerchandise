using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeWCommodityService : WarehouseService, IDTOService<EmployeeWCommodity>
    {
        public EmployeeWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeWCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeWCommodity>($"/api/EmployeeWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeWCommodity>>("/api/EmployeeWCommodity");
        }

        public async Task<EmployeeWCommodity?> PostAsync(EmployeeWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeWCommodity? EmployeeWCommodity = JsonSerializer.Deserialize<EmployeeWCommodity>(JsonEmployeeWCommodity);
            return EmployeeWCommodity;
        }

        public async Task<EmployeeWCommodity?> PutAsync(EmployeeWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeWCommodity? EmployeeWCommodity = JsonSerializer.Deserialize<EmployeeWCommodity>(JsonEmployeeWCommodity);

            return EmployeeWCommodity;
        }
    }
}
