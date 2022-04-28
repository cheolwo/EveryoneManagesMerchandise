using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofOrder.ofEmployer
{
    public class EmployerSOCommodityService : OrderService, IDTOService<EmployerSOCommodity>
    {
        public EmployerSOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerSOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerSOCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerSOCommodity>($"/api/EmployerSOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerSOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerSOCommodity>>("/api/EmployerSOCommodity");
        }

        public async Task PostAsync(EmployerSOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerSOCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerSOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerSOCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
