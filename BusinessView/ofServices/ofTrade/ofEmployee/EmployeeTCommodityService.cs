using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
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

        public async Task<EmployeeTCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeTCommodity>($"/api/EmployeeTCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeTCommodity>>("/api/EmployeeTCommodity");
        }

        public async Task<EmployeeTCommodity?> PostAsync(EmployeeTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeTCommodity? EmployeeTCommodity = JsonSerializer.Deserialize<EmployeeTCommodity>(JsonEmployeeTCommodity);
            return EmployeeTCommodity;
        }

        public async Task<EmployeeTCommodity?> PutAsync(EmployeeTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeTCommodity? EmployeeTCommodity = JsonSerializer.Deserialize<EmployeeTCommodity>(JsonEmployeeTCommodity);

            return EmployeeTCommodity;
        }
    }
}
