using BusinessView.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployee
{
    public class EmployeeGOCService : GroupOrderService, IDTOService<EmployeeGOC>
    {
        public EmployeeGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeGOC?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeGOC>($"/api/EmployeeGOC/{id}");
        }

        public async Task<IEnumerable<EmployeeGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeGOC>>("/api/EmployeeGOC");
        }

        public async Task PostAsync(EmployeeGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
