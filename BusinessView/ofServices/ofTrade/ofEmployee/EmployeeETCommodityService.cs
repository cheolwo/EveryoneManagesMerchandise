using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofTrade.ofEmployee
{
    public class EmployeeETCommodityService : TradeService, IDTOService<EmployeeETCommodity>
    {
        public EmployeeETCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeETCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeETCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeETCommodity>($"/api/EmployeeETCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeETCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeETCommodity>>("/api/EmployeeETCommodity");
        }

        public async Task PostAsync(EmployeeETCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeETCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeETCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeETCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
