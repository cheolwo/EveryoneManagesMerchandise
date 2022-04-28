using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofOrder.ofEmployee
{
    public class EmployeeMOCommodityService : OrderService, IDTOService<EmployeeMOCommodity>
    {
        public EmployeeMOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeMOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeMOCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMOCommodity>($"/api/EmployeeMOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeMOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMOCommodity>>("/api/EmployeeMOCommodity");
        }

        public async Task PostAsync(EmployeeMOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMOCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeMOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMOCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
