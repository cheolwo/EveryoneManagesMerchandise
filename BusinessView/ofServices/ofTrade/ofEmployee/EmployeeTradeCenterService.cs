using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofTrade.ofEmployee
{
    public class EmployeeTradeCenterService : TradeService, IDTOService<EmployeeTradeCenter>
    {
        public EmployeeTradeCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeTradeCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeTradeCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeTradeCenter>($"/api/EmployeeTradeCenter/{id}");
        }

        public async Task<IEnumerable<EmployeeTradeCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeTradeCenter>>("/api/EmployeeTradeCenter");
        }

        public async Task PostAsync(EmployeeTradeCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeTradeCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeTradeCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeTradeCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
