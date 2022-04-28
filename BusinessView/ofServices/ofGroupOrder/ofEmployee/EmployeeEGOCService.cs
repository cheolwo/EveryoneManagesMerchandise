using BusinessView.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployee
{
    public class EmployeeEGOCService : GroupOrderService, IDTOService<EmployeeEGOC>
    {
        public EmployeeEGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeEGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeEGOC?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeEGOC>($"/api/EmployeeEGOC/{id}");
        }

        public async Task<IEnumerable<EmployeeEGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeEGOC>>("/api/EmployeeEGOC");
        }

        public async Task PostAsync(EmployeeEGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeEGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeEGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeEGOC", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
