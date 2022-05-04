using BusinessView.ofTrade.ofEmployee;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeSTCommodityService : TradeService, IDTOService<EmployeeSTCommodity>
    {
        public EmployeeSTCommodityService(TradeServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeSTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeSTCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeSTCommodity>($"/api/EmployeeSTCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeSTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeSTCommodity>>("/api/EmployeeSTCommodity");
        }

        public async Task<EmployeeSTCommodity?> PostAsync(EmployeeSTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeSTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeSTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeSTCommodity? EmployeeSTCommodity = JsonSerializer.Deserialize<EmployeeSTCommodity>(JsonEmployeeSTCommodity);
            return EmployeeSTCommodity;
        }

        public async Task<EmployeeSTCommodity?> PutAsync(EmployeeSTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeSTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeSTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeSTCommodity? EmployeeSTCommodity = JsonSerializer.Deserialize<EmployeeSTCommodity>(JsonEmployeeSTCommodity);

            return EmployeeSTCommodity;
        }
    }
}
