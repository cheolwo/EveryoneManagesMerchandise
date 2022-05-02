using BusinessView.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerEWCommodityService : WarehouseService, IDTOService<EmployerEWCommodity>
    {
        public EmployerEWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerEWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerEWCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerEWCommodity>($"/api/EmployerEWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerEWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerEWCommodity>>("/api/EmployerEWCommodity");
        }

        public async Task<EmployerEWCommodity?> PostAsync(EmployerEWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerEWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerEWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerEWCommodity? EmployerEWCommodity = JsonSerializer.Deserialize<EmployerEWCommodity>(JsonEmployerEWCommodity);
            return EmployerEWCommodity;
        }

        public async Task<EmployerEWCommodity?> PutAsync(EmployerEWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerEWCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerEWCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerEWCommodity? EmployerEWCommodity = JsonSerializer.Deserialize<EmployerEWCommodity>(JsonEmployerEWCommodity);

            return EmployerEWCommodity;
        }
    }
}
