using BusinessView.ofDTO.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployee
{
    public class EmployeeSGOCService : GroupOrderService, IDTOService<EmployeeSGOC>
    {
        public EmployeeSGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeSGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeSGOC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeSGOC>($"/api/EmployeeSGOC/{id}");
        }

        public async Task<IEnumerable<EmployeeSGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeSGOC>>("/api/EmployeeSGOC");
        }

        public async Task<EmployeeSGOC?> PostAsync(EmployeeSGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeSGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeSGOC = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeSGOC? employeeSGOC = JsonSerializer.Deserialize<EmployeeSGOC>(JsonEmployeeSGOC);
            return employeeSGOC;
        }

        public async Task<EmployeeSGOC?> PutAsync(EmployeeSGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeSGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeSGOC = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeSGOC? employeeSGOC = JsonSerializer.Deserialize<EmployeeSGOC>(JsonEmployeeSGOC);

            return employeeSGOC;
        }
    }
}
