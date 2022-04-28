using BusinessView.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse.ofEmployee
{
    public class EmployeeMWCommodityService : WarehouseService, IDTOService<EmployeeMWCommodity>
    {
        public EmployeeMWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeMWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeMWCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMWCommodity>($"/api/EmployeeMWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeMWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMWCommodity>>("/api/EmployeeMWCommodity");
        }

        public async Task PostAsync(EmployeeMWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeMWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
