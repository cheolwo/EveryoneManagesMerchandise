using BusinessView.ofDTO.ofOrder.ofEmployer;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerOrderCenterService : OrderService, IDTOService<EmployerOrderCenter>
    {
        public EmployerOrderCenterService(OrderServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerOrderCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerOrderCenter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerOrderCenter>($"/api/EmployerOrderCenter/{id}");
        }

        public async Task<IEnumerable<EmployerOrderCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerOrderCenter>>("/api/EmployerOrderCenter");
        }

        public async Task<EmployerOrderCenter?> PostAsync(EmployerOrderCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerOrderCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerOrderCenter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerOrderCenter? EmployerOrderCenter = JsonSerializer.Deserialize<EmployerOrderCenter>(JsonEmployerOrderCenter);
            return EmployerOrderCenter;
        }

        public async Task<EmployerOrderCenter?> PutAsync(EmployerOrderCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerOrderCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerOrderCenter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerOrderCenter? EmployerOrderCenter = JsonSerializer.Deserialize<EmployerOrderCenter>(JsonEmployerOrderCenter);

            return EmployerOrderCenter;
        }
    }
}
