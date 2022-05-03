using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployerHREmployeeService : HRService, IDTOService<EmployerHREmployee>
    {
        public EmployerHREmployeeService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerHREmployee/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerHREmployee?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerHREmployee>($"/api/EmployerHREmployee/{id}");
        }

        public async Task<IEnumerable<EmployerHREmployee>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerHREmployee>>("/api/EmployerHREmployee");
        }

        public async Task<EmployerHREmployee?> PostAsync(EmployerHREmployee entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerHREmployee", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerHREmployee = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerHREmployee? EmployerHREmployee = JsonSerializer.Deserialize<EmployerHREmployee>(JsonEmployerHREmployee);
            return EmployerHREmployee;
        }

        public async Task<EmployerHREmployee?> PutAsync(EmployerHREmployee entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerHREmployee", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerHREmployee = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerHREmployee? EmployerHREmployee = JsonSerializer.Deserialize<EmployerHREmployee>(JsonEmployerHREmployee);

            return EmployerHREmployee;
        }
    }
}
