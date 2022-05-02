using BusinessView.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerWCommodityService : WarehouseService, IDTOService<EmployerWCommodity>
    {
        public EmployerWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerWCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerWCommodity>($"/api/EmployerWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerWCommodity>>("/api/EmployerWCommodity");
        }

        public async Task<EmployerWCommodity?> PostAsync(EmployerWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerWCommodity? EmployerWCommodity = JsonSerializer.Deserialize<EmployerWCommodity>(JsonEmployerWCommodity);
            return EmployerWCommodity;
        }

        public async Task<EmployerWCommodity?> PutAsync(EmployerWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerWCommodity? EmployerWCommodity = JsonSerializer.Deserialize<EmployerWCommodity>(JsonEmployerWCommodity);

            return EmployerWCommodity;
        }
    }
}
