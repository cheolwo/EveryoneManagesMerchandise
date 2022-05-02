using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployerEmployeeRoleService : HRService, IDTOService<EmployerEmployeeRole>
    {
        public EmployerEmployeeRoleService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerEmployeeRole/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerEmployeeRole?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerEmployeeRole>($"/api/EmployerEmployeeRole/{id}");
        }

        public async Task<IEnumerable<EmployerEmployeeRole>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerEmployeeRole>>("/api/EmployerEmployeeRole");
        }

        public async Task<EmployerEmployeeRole?> PostAsync(EmployerEmployeeRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerEmployeeRole", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerEmployeeRole = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerEmployeeRole? EmployerEmployeeRole = JsonSerializer.Deserialize<EmployerEmployeeRole>(JsonEmployerEmployeeRole);
            return EmployerEmployeeRole;
        }

        public async Task<EmployerEmployeeRole?> PutAsync(EmployerEmployeeRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerEmployeeRole", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerEmployeeRole = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerEmployeeRole? EmployerEmployeeRole = JsonSerializer.Deserialize<EmployerEmployeeRole>(JsonEmployerEmployeeRole);

            return EmployerEmployeeRole;
        }
    }
}
