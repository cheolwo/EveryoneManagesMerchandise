using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeTradeCenterService : TradeService, IDTOService<EmployeeTradeCenter>
    {
        public EmployeeTradeCenterService(TradeServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeTradeCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeTradeCenter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeTradeCenter>($"/api/EmployeeTradeCenter/{id}");
        }

        public async Task<IEnumerable<EmployeeTradeCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeTradeCenter>>("/api/EmployeeTradeCenter");
        }

        public async Task<EmployeeTradeCenter?> PostAsync(EmployeeTradeCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeTradeCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeTradeCenter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeTradeCenter? EmployeeTradeCenter = JsonSerializer.Deserialize<EmployeeTradeCenter>(JsonEmployeeTradeCenter);
            return EmployeeTradeCenter;
        }

        public async Task<EmployeeTradeCenter?> PutAsync(EmployeeTradeCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeTradeCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeTradeCenter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeTradeCenter? EmployeeTradeCenter = JsonSerializer.Deserialize<EmployeeTradeCenter>(JsonEmployeeTradeCenter);

            return EmployeeTradeCenter;
        }
    }
}
