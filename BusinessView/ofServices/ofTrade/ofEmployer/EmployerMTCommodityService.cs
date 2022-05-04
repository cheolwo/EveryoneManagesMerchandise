using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerMTCommodityService : TradeService, IDTOService<EmployerMTCommodity>
    {
        public EmployerMTCommodityService(TradeServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMTCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMTCommodity>($"/api/EmployerMTCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerMTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMTCommodity>>("/api/EmployerMTCommodity");
        }

        public async Task<EmployerMTCommodity?> PostAsync(EmployerMTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerMTCommodity? EmployerMTCommodity = JsonSerializer.Deserialize<EmployerMTCommodity>(JsonEmployerMTCommodity);
            return EmployerMTCommodity;
        }

        public async Task<EmployerMTCommodity?> PutAsync(EmployerMTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerMTCommodity? EmployerMTCommodity = JsonSerializer.Deserialize<EmployerMTCommodity>(JsonEmployerMTCommodity);

            return EmployerMTCommodity;
        }
    }
}
