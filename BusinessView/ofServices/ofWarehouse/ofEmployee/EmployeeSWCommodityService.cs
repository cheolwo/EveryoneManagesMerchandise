using BusinessView.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeSWCommodityService : WarehouseService, IDTOService<EmployeeSWCommodity>
    {
        public EmployeeSWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeSWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeSWCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeSWCommodity>($"/api/EmployeeSWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeSWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeSWCommodity>>("/api/EmployeeSWCommodity");
        }

        public async Task<EmployeeSWCommodity?> PostAsync(EmployeeSWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeSWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeSWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeSWCommodity? EmployeeSWCommodity = JsonSerializer.Deserialize<EmployeeSWCommodity>(JsonEmployeeSWCommodity);
            return EmployeeSWCommodity;
        }

        public async Task<EmployeeSWCommodity?> PutAsync(EmployeeSWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeSWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeSWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeSWCommodity? EmployeeSWCommodity = JsonSerializer.Deserialize<EmployeeSWCommodity>(JsonEmployeeSWCommodity);

            return EmployeeSWCommodity;
        }
    }
}
