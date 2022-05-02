using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerMOCommodityService : OrderService, IDTOService<EmployerMOCommodity>
    {
        public EmployerMOCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMOCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMOCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMOCommodity>($"/api/EmployerMOCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerMOCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMOCommodity>>("/api/EmployerMOCommodity");
        }

        public async Task<EmployerMOCommodity?> PostAsync(EmployerMOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerMOCommodity? EmployerMOCommodity = JsonSerializer.Deserialize<EmployerMOCommodity>(JsonEmployerMOCommodity);
            return EmployerMOCommodity;
        }

        public async Task<EmployerMOCommodity?> PutAsync(EmployerMOCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMOCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMOCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerMOCommodity? EmployerMOCommodity = JsonSerializer.Deserialize<EmployerMOCommodity>(JsonEmployerMOCommodity);

            return EmployerMOCommodity;
        }
    }
}
