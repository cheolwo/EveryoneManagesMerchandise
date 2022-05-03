using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerOCommodityService : OrderService, IDTOService<EmployerOCommodity>
    {
        public EmployerOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerOCommodity>($"/api/EmployerOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerOCommodity>>("/api/EmployerOCommodity");
        }

        public async Task<EmployerOCommodity?> PostAsync(EmployerOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerOCommodity? EmployerOCommodity = JsonSerializer.Deserialize<EmployerOCommodity>(JsonEmployerOCommodity);
            return EmployerOCommodity;
        }

        public async Task<EmployerOCommodity?> PutAsync(EmployerOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerOCommodity? EmployerOCommodity = JsonSerializer.Deserialize<EmployerOCommodity>(JsonEmployerOCommodity);

            return EmployerOCommodity;
        }
    }
}
