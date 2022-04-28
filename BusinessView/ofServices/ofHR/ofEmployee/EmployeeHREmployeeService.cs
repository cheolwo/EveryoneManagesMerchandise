using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeHREmployeeService : HRService, IDTOService<EmployeeHREmployee>
    {
        public EmployeeHREmployeeService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeHREmployee/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeHREmployee?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeHREmployee>($"/api/EmployeeHREmployee/{id}");
        }

        public async Task<IEnumerable<EmployeeHREmployee>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeHREmployee>>("/api/EmployeeHREmployee");
        }

        public async Task PostAsync(EmployeeHREmployee entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeHREmployee", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeHREmployee entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeHREmployee", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
