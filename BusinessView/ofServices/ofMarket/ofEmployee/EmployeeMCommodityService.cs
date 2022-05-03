using BusinessView.ofDTO.ofMarket.ofEmployee;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeMCommodityService : MarketService, IDTOService<EmployeeMCommodity>
    {
        public EmployeeMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeMCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMCommodity>($"/api/EmployeeMCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMCommodity>>("/api/EmployeeMCommodity");
        }

        public async Task<EmployeeMCommodity?> PostAsync(EmployeeMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeMCommodity? EmployeeMCommodity = JsonSerializer.Deserialize<EmployeeMCommodity>(JsonEmployeeMCommodity);
            return EmployeeMCommodity;
        }

        public async Task<EmployeeMCommodity?> PutAsync(EmployeeMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeMCommodity? EmployeeMCommodity = JsonSerializer.Deserialize<EmployeeMCommodity>(JsonEmployeeMCommodity);

            return EmployeeMCommodity;
        }
    }
}
