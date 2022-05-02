using BusinessView.ofGroupOrder.ofEmployer;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployer
{
    public class EmployerGOCService : GroupOrderService, IDTOService<EmployerGOC>
    {
        public EmployerGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerGOC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerGOC>($"/api/EmployerGOC/{id}");
        }

        public async Task<IEnumerable<EmployerGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerGOC>>("/api/EmployerGOC");
        }

        public async Task<EmployerGOC?> PostAsync(EmployerGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerGOC = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerGOC? EmployerGOC = JsonSerializer.Deserialize<EmployerGOC>(JsonEmployerGOC);
            return EmployerGOC;
        }

        public async Task<EmployerGOC?> PutAsync(EmployerGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerGOC = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerGOC? EmployerGOC = JsonSerializer.Deserialize<EmployerGOC>(JsonEmployerGOC);

            return EmployerGOC;
        }
    }
}
