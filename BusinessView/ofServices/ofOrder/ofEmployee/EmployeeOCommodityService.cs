using BusinessView.ofDTO.ofOrder.ofEmployee;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeOCommodityService : OrderService, IDTOService<EmployeeOCommodity>
    {
        public EmployeeOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeOCommodity>($"/api/EmployeeOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeOCommodity>>("/api/EmployeeOCommodity");
        }

        public async Task<EmployeeOCommodity?> PostAsync(EmployeeOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeOCommodity? EmployeeOCommodity = JsonSerializer.Deserialize<EmployeeOCommodity>(JsonEmployeeOCommodity);
            return EmployeeOCommodity;
        }

        public async Task<EmployeeOCommodity?> PutAsync(EmployeeOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeOCommodity? EmployeeOCommodity = JsonSerializer.Deserialize<EmployeeOCommodity>(JsonEmployeeOCommodity);

            return EmployeeOCommodity;
        }
    }
}
