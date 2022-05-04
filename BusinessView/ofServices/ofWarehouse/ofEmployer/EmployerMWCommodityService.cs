using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerMWCommodityService : WarehouseService, IDTOService<EmployerMWCommodity>
    {
        public EmployerMWCommodityService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMWCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMWCommodity>($"/api/EmployerMWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerMWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMWCommodity>>("/api/EmployerMWCommodity");
        }

        public async Task<EmployerMWCommodity?> PostAsync(EmployerMWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerMWCommodity? EmployerMWCommodity = JsonSerializer.Deserialize<EmployerMWCommodity>(JsonEmployerMWCommodity);
            return EmployerMWCommodity;
        }

        public async Task<EmployerMWCommodity?> PutAsync(EmployerMWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerMWCommodity? EmployerMWCommodity = JsonSerializer.Deserialize<EmployerMWCommodity>(JsonEmployerMWCommodity);

            return EmployerMWCommodity;
        }
    }
}
