using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
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

        public async Task<EmployeeMOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMOCommodity>($"/api/EmployeeMOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeMOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMOCommodity>>("/api/EmployeeMOCommodity");
        }

        public async Task<EmployeeMOCommodity?> PostAsync(EmployeeMOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeMOCommodity? EmployeeMOCommodity = JsonSerializer.Deserialize<EmployeeMOCommodity>(JsonEmployeeMOCommodity);
            return EmployeeMOCommodity;
        }

        public async Task<EmployeeMOCommodity?> PutAsync(EmployeeMOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeMOCommodity? EmployeeMOCommodity = JsonSerializer.Deserialize<EmployeeMOCommodity>(JsonEmployeeMOCommodity);

            return EmployeeMOCommodity;
        }
    }
}
