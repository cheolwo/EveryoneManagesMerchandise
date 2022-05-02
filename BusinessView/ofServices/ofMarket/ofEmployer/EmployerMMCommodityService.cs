using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerMMCommodityService : MarketService, IDTOService<EmployerMMCommodity>
    {
        public EmployerMMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMMCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMMCommodity>($"/api/EmployerMMCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerMMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMMCommodity>>("/api/EmployerMMCommodity");
        }

        public async Task<EmployerMMCommodity?> PostAsync(EmployerMMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerMMCommodity? EmployerMMCommodity = JsonSerializer.Deserialize<EmployerMMCommodity>(JsonEmployerMMCommodity);
            return EmployerMMCommodity;
        }

        public async Task<EmployerMMCommodity?> PutAsync(EmployerMMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMMCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMMCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerMMCommodity? EmployerMMCommodity = JsonSerializer.Deserialize<EmployerMMCommodity>(JsonEmployerMMCommodity);

            return EmployerMMCommodity;
        }
    }
}
