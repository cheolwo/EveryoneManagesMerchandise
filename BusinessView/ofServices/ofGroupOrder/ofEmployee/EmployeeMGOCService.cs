using BusinessView.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployee
{
    public class EmployeeMGOCService : GroupOrderService, IDTOService<EmployeeMGOC>
    {
        public EmployeeMGOCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeMGOC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeMGOC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMGOC>($"/api/EmployeeMGOC/{id}");
        }

        public async Task<IEnumerable<EmployeeMGOC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMGOC>>("/api/EmployeeMGOC");
        }

        public async Task<EmployeeMGOC?> PostAsync(EmployeeMGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMGOC = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeMGOC? employeeMGOC = JsonSerializer.Deserialize<EmployeeMGOC>(JsonEmployeeMGOC);
            return employeeMGOC;
        }

        public async Task<EmployeeMGOC?> PutAsync(EmployeeMGOC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMGOC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMGOC = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeMGOC? employeeMGOC = JsonSerializer.Deserialize<EmployeeMGOC>(JsonEmployeeMGOC);

            return employeeMGOC;
        }
    }
}
