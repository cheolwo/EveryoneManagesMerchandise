using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofTrade.ofEmployee
{
    public class EmployeeTCommodityService : TradeService, IDTOService<EmployeeTCommodity>
    {
        public EmployeeTCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeTCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeTCommodity>($"/api/EmployeeTCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeTCommodity>>("/api/EmployeeTCommodity");
        }

        public async Task PostAsync(EmployeeTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeTCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeTCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
