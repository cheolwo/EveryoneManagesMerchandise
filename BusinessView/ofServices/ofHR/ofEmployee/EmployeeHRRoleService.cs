using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeHRRoleService : HRService, IDTOService<EmployeeHRRole>
    {
        public EmployeeHRRoleService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeHRRole/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeHRRole?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeHRRole>($"/api/EmployeeHRRole/{id}");
        }

        public async Task<IEnumerable<EmployeeHRRole>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeHRRole>>("/api/EmployeeHRRole");
        }

        public async Task PostAsync(EmployeeHRRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeHRRole", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeHRRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeHRRole", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
