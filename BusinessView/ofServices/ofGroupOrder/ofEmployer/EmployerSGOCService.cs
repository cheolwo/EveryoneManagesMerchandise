using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployer
{
    public class EmployerSGOCService : GroupOrderService, IDTOService<EmployerSGOC>
    {
        public EmployerSGOCService(GroupOrderServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerSGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerSGOC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerSGOC>($"/api/EmployerSGOC/{id}");
        }

        public async Task<IEnumerable<EmployerSGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerSGOC>>("/api/EmployerSGOC");
        }

        public async Task<EmployerSGOC?> PostAsync(EmployerSGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerSGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerSGOC = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerSGOC? EmployerSGOC = JsonSerializer.Deserialize<EmployerSGOC>(JsonEmployerSGOC);
            return EmployerSGOC;
        }

        public async Task<EmployerSGOC?> PutAsync(EmployerSGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerSGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerSGOC = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerSGOC? EmployerSGOC = JsonSerializer.Deserialize<EmployerSGOC>(JsonEmployerSGOC);

            return EmployerSGOC;
        }
    }
}
