using BusinessView.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofEmployee
{
    public class EmployeeEWCommodityService : WarehouseService, IDTOService<EmployeeEWCommodity>
    {
        public EmployeeEWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeEWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeEWCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeEWCommodity>($"/api/EmployeeEWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeEWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeEWCommodity>>("/api/EmployeeEWCommodity");
        }

        public async Task PostAsync(EmployeeEWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeEWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeEWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeEWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
