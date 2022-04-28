using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofMarket.ofEmployer
{
    public class EmployerMCommodityService : MarketService, IDTOService<EmployerMCommodity>
    {
        public EmployerMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMCommodity>($"/api/EmployerMCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMCommodity>>("/api/EmployerMCommodity");
        }

        public async Task PostAsync(EmployerMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
