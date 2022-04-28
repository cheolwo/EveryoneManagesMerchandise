using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofMarket.ofEmployer
{
    public class EmployerEMCommodityService : MarketService, IDTOService<EmployerEMCommodity>
    {
        public EmployerEMCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerEMCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerEMCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerEMCommodity>($"/api/EmployerEMCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerEMCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerEMCommodity>>("/api/EmployerEMCommodity");
        }

        public async Task PostAsync(EmployerEMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerEMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerEMCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerEMCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
