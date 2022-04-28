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

        public async Task<EmployerMGOC?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMGOC>($"/api/EmployerMGOC/{id}");
        }

        public async Task<IEnumerable<EmployerMGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMGOC>>("/api/EmployerMGOC");
        }

        public async Task PostAsync(EmployerMGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerMGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
