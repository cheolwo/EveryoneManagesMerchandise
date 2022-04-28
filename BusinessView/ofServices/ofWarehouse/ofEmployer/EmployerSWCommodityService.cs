using BusinessView.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofWarehouse
{
    public class EmployerSWCommodityService : WarehouseService, IDTOService<EmployerSWCommodity>
    {
        public EmployerSWCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerSWCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerSWCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerSWCommodity>($"/api/EmployerSWCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerSWCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerSWCommodity>>("/api/EmployerSWCommodity");
        }

        public async Task PostAsync(EmployerSWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerSWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerSWCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerSWCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
