using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerETCommodityService : TradeService, IDTOService<EmployerETCommodity>
    {
        public EmployerETCommodityService(TradeServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerETCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerETCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerETCommodity>($"/api/EmployerETCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerETCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerETCommodity>>("/api/EmployerETCommodity");
        }

        public async Task<EmployerETCommodity?> PostAsync(EmployerETCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerETCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerETCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerETCommodity? EmployerETCommodity = JsonSerializer.Deserialize<EmployerETCommodity>(JsonEmployerETCommodity);
            return EmployerETCommodity;
        }

        public async Task<EmployerETCommodity?> PutAsync(EmployerETCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerETCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerETCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerETCommodity? EmployerETCommodity = JsonSerializer.Deserialize<EmployerETCommodity>(JsonEmployerETCommodity);

            return EmployerETCommodity;
        }
    }
}
