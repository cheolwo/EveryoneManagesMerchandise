using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofMarket.ofEmployee
{
    public class EmployeeEMCommodityService : MarketService, IDTOService<EmployeeEMCommodity>
    {
        public EmployeeEMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeEMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeEMCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeEMCommodity>($"/api/EmployeeEMCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeEMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeEMCommodity>>("/api/EmployeeEMCommodity");
        }

        public async Task PostAsync(EmployeeEMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeEMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeEMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeEMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
