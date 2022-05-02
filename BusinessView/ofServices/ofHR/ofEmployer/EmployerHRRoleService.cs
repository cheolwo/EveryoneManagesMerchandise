using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployerHRRoleService : HRService, IDTOService<EmployerHRRole>
    {
        public EmployerHRRoleService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerHRRole/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerHRRole?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerHRRole>($"/api/EmployerHRRole/{id}");
        }

        public async Task<IEnumerable<EmployerHRRole>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerHRRole>>("/api/EmployerHRRole");
        }

        public async Task<EmployerHRRole?> PostAsync(EmployerHRRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerHRRole", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerHRRole = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerHRRole? EmployerHRRole = JsonSerializer.Deserialize<EmployerHRRole>(JsonEmployerHRRole);
            return EmployerHRRole;
        }

        public async Task<EmployerHRRole?> PutAsync(EmployerHRRole entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerHRRole", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerHRRole = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerHRRole? EmployerHRRole = JsonSerializer.Deserialize<EmployerHRRole>(JsonEmployerHRRole);

            return EmployerHRRole;
        }
    }
}
