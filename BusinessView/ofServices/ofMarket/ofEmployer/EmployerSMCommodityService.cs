using BusinessView.ofDTO.ofMarket.ofEmployer;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerSMCommodityService : MarketService, IDTOService<EmployerSMCommodity>
    {
        public EmployerSMCommodityService(MarketServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerSMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerSMCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerSMCommodity>($"/api/EmployerSMCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerSMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerSMCommodity>>("/api/EmployerSMCommodity");
        }

        public async Task<EmployerSMCommodity?> PostAsync(EmployerSMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerSMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerSMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerSMCommodity? EmployerSMCommodity = JsonSerializer.Deserialize<EmployerSMCommodity>(JsonEmployerSMCommodity);
            return EmployerSMCommodity;
        }

        public async Task<EmployerSMCommodity?> PutAsync(EmployerSMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerSMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerSMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerSMCommodity? EmployerSMCommodity = JsonSerializer.Deserialize<EmployerSMCommodity>(JsonEmployerSMCommodity);

            return EmployerSMCommodity;
        }
    }
}
