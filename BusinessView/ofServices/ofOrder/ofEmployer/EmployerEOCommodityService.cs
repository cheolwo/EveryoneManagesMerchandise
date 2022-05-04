using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerEOCommodityService : OrderService, IDTOService<EmployerEOCommodity>
    {
        public EmployerEOCommodityService(OrderServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerEOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerEOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerEOCommodity>($"/api/EmployerEOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerEOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerEOCommodity>>("/api/EmployerEOCommodity");
        }

        public async Task<EmployerEOCommodity?> PostAsync(EmployerEOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerEOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerEOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerEOCommodity? EmployerEOCommodity = JsonSerializer.Deserialize<EmployerEOCommodity>(JsonEmployerEOCommodity);
            return EmployerEOCommodity;
        }

        public async Task<EmployerEOCommodity?> PutAsync(EmployerEOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerEOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerEOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerEOCommodity? EmployerEOCommodity = JsonSerializer.Deserialize<EmployerEOCommodity>(JsonEmployerEOCommodity);

            return EmployerEOCommodity;
        }
    }
}
