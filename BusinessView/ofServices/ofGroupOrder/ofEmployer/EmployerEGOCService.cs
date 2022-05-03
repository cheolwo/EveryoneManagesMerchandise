using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployer
{
    public class EmployerEGOCService : GroupOrderService, IDTOService<EmployerEGOC>
    {
        public EmployerEGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerEGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerEGOC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerEGOC>($"/api/EmployerEGOC/{id}");
        }

        public async Task<IEnumerable<EmployerEGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerEGOC>>("/api/EmployerEGOC");
        }

        public async Task<EmployerEGOC?> PostAsync(EmployerEGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerEGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerEGOC = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerEGOC? EmployerEGOC = JsonSerializer.Deserialize<EmployerEGOC>(JsonEmployerEGOC);
            return EmployerEGOC;
        }

        public async Task<EmployerEGOC?> PutAsync(EmployerEGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerEGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerEGOC = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerEGOC? EmployerEGOC = JsonSerializer.Deserialize<EmployerEGOC>(JsonEmployerEGOC);

            return EmployerEGOC;
        }
    }
}
