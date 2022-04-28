using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofTrade.ofEmployer
{
    public class EmployerTradeCenterService : TradeService, IDTOService<EmployerTradeCenter>
    {
        public EmployerTradeCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerTradeCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerTradeCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerTradeCenter>($"/api/EmployerTradeCenter/{id}");
        }

        public async Task<IEnumerable<EmployerTradeCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerTradeCenter>>("/api/EmployerTradeCenter");
        }

        public async Task PostAsync(EmployerTradeCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerTradeCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerTradeCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerTradeCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
