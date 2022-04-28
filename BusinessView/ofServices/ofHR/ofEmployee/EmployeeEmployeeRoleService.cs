using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeEmployeeRoleService : HRService, IDTOService<EmployeeEmployeeRole>
    {
        public EmployeeEmployeeRoleService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeEmployeeRole/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeEmployeeRole?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeEmployeeRole>($"/api/EmployeeEmployeeRole/{id}");
        }

        public async Task<IEnumerable<EmployeeEmployeeRole>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeEmployeeRole>>("/api/EmployeeEmployeeRole");
        }

        public async Task PostAsync(EmployeeEmployeeRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeEmployeeRole", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeEmployeeRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeEmployeeRole", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
