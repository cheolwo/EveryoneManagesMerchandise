using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployer
{
    public class EmployerMGOCService : GroupOrderService, IDTOService<EmployerMGOC>
    {
        public EmployerMGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMGOC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMGOC>($"/api/EmployerMGOC/{id}");
        }

        public async Task<IEnumerable<EmployerMGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMGOC>>("/api/EmployerMGOC");
        }

        public async Task<EmployerMGOC?> PostAsync(EmployerMGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMGOC = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerMGOC? EmployerMGOC = JsonSerializer.Deserialize<EmployerMGOC>(JsonEmployerMGOC);
            return EmployerMGOC;
        }

        public async Task<EmployerMGOC?> PutAsync(EmployerMGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMGOC = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerMGOC? EmployerMGOC = JsonSerializer.Deserialize<EmployerMGOC>(JsonEmployerMGOC);

            return EmployerMGOC;
        }
    }
}
