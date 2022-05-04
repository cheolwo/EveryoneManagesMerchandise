using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeEOCommodityService : OrderService, IDTOService<EmployeeEOCommodity>
    {
        public EmployeeEOCommodityService(OrderServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeEOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeEOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeEOCommodity>($"/api/EmployeeEOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeEOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeEOCommodity>>("/api/EmployeeEOCommodity");
        }

        public async Task<EmployeeEOCommodity?> PostAsync(EmployeeEOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeEOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeEOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeEOCommodity? EmployeeEOCommodity = JsonSerializer.Deserialize<EmployeeEOCommodity>(JsonEmployeeEOCommodity);
            return EmployeeEOCommodity;
        }

        public async Task<EmployeeEOCommodity?> PutAsync(EmployeeEOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeEOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeEOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeEOCommodity? EmployeeEOCommodity = JsonSerializer.Deserialize<EmployeeEOCommodity>(JsonEmployeeEOCommodity);

            return EmployeeEOCommodity;
        }
    }
}
