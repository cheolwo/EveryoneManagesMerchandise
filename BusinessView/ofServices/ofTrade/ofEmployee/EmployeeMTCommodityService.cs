using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofTrade.ofEmployee
{
    public class EmployeeMTCommodityService : TradeService, IDTOService<EmployeeMTCommodity>
    {
        public EmployeeMTCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeMTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeMTCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMTCommodity>($"/api/EmployeeMTCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeMTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMTCommodity>>("/api/EmployeeMTCommodity");
        }

        public async Task PostAsync(EmployeeMTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMTCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeMTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMTCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
