using BusinessView.ofGroupOrder.ofEmployee;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployee
{
    public class EmployeeGOCCService : GroupOrderService, IDTOService<EmployeeGOCC>
    {
        public EmployeeGOCCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeGOCC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeGOCC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeGOCC>($"/api/EmployeeGOCC/{id}");
        }

        public async Task<IEnumerable<EmployeeGOCC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeGOCC>>("/api/EmployeeGOCC");
        }

        public async Task<EmployeeGOCC?> PostAsync(EmployeeGOCC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeGOCC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeGOCC = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeGOCC? employeeGOCC = JsonSerializer.Deserialize<EmployeeGOCC>(JsonEmployeeGOCC);
            return employeeGOCC;
        }

        public async Task<EmployeeGOCC?> PutAsync(EmployeeGOCC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeGOCC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeGOCC = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeGOCC? employeeGOCC = JsonSerializer.Deserialize<EmployeeGOCC>(JsonEmployeeGOCC);

            return employeeGOCC;
        }
    }
}
