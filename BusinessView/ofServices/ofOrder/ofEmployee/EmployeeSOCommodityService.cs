using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofOrder.ofEmployee
{
    public class EmployeeSOCommodityService : OrderService, IDTOService<EmployeeSOCommodity>
    {
        public EmployeeSOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeSOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeSOCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeSOCommodity>($"/api/EmployeeSOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeSOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeSOCommodity>>("/api/EmployeeSOCommodity");
        }

        public async Task PostAsync(EmployeeSOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeSOCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeSOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeSOCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
