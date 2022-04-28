using BusinessView.ofMarket.ofEmployee;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofMarket.ofEmployee
{
    public class EmployeeSMCommodityService : MarketService, IDTOService<EmployeeSMCommodity>
    {
        public EmployeeSMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeSMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeSMCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeSMCommodity>($"/api/EmployeeSMCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeSMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeSMCommodity>>("/api/EmployeeSMCommodity");
        }

        public async Task PostAsync(EmployeeSMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeSMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeSMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeSMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
