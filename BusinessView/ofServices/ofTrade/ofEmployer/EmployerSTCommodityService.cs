using BusinessView.ofTrade.ofEmployer;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofTrade.ofEmployer
{
    public class EmployerSTCommodityService : TradeService, IDTOService<EmployerSTCommodity>
    {
        public EmployerSTCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerSTCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerSTCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerSTCommodity>($"/api/EmployerSTCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerSTCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerSTCommodity>>("/api/EmployerSTCommodity");
        }

        public async Task PostAsync(EmployerSTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerSTCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerSTCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerSTCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
