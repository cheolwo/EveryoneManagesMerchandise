using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerTCommodityService : TradeService, IDTOService<EmployerTCommodity>
    {
        public EmployerTCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerTCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerTCommodity>($"/api/EmployerTCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerTCommodity>>("/api/EmployerTCommodity");
        }

        public async Task<EmployerTCommodity?> PostAsync(EmployerTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerTCommodity? EmployerTCommodity = JsonSerializer.Deserialize<EmployerTCommodity>(JsonEmployerTCommodity);
            return EmployerTCommodity;
        }

        public async Task<EmployerTCommodity?> PutAsync(EmployerTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerTCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerTCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerTCommodity? EmployerTCommodity = JsonSerializer.Deserialize<EmployerTCommodity>(JsonEmployerTCommodity);

            return EmployerTCommodity;
        }
    }
}
