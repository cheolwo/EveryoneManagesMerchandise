using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeMMCommodityService : MarketService, IDTOService<EmployeeMMCommodity>
    {
        public EmployeeMMCommodityService(MarketServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeMMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeMMCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMMCommodity>($"/api/EmployeeMMCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeMMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMMCommodity>>("/api/EmployeeMMCommodity");
        }

        public async Task<EmployeeMMCommodity?> PostAsync(EmployeeMMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeMMCommodity? EmployeeMMCommodity = JsonSerializer.Deserialize<EmployeeMMCommodity>(JsonEmployeeMMCommodity);
            return EmployeeMMCommodity;
        }

        public async Task<EmployeeMMCommodity?> PutAsync(EmployeeMMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeMMCommodity? EmployeeMMCommodity = JsonSerializer.Deserialize<EmployeeMMCommodity>(JsonEmployeeMMCommodity);

            return EmployeeMMCommodity;
        }
    }
}
