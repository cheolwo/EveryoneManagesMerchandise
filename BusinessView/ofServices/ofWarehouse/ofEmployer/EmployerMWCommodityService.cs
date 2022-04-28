using BusinessView.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse
{
    public class EmployerMWCommodityService : WarehouseService, IDTOService<EmployerMWCommodity>
    {
        public EmployerMWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMWCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMWCommodity>($"/api/EmployerMWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerMWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMWCommodity>>("/api/EmployerMWCommodity");
        }

        public async Task PostAsync(EmployerMWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerMWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
