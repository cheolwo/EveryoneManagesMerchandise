using BusinessView.ofDTO.ofHR.ofEmployee;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeHRCenterService : HRService, IDTOService<EmployeeHRCenter>
    {
        public EmployeeHRCenterService(HRServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeHRCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeHRCenter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeHRCenter>($"/api/EmployeeHRCenter/{id}");
        }

        public async Task<IEnumerable<EmployeeHRCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeHRCenter>>("/api/EmployeeHRCenter");
        }

        public async Task<EmployeeHRCenter?> PostAsync(EmployeeHRCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeHRCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeHRCenter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeHRCenter? employeeHRCenter = JsonSerializer.Deserialize<EmployeeHRCenter>(JsonEmployeeHRCenter);
            return employeeHRCenter;
        }

        public async Task<EmployeeHRCenter?> PutAsync(EmployeeHRCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeHRCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeHRCenter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeHRCenter? employeeHRCenter = JsonSerializer.Deserialize<EmployeeHRCenter>(JsonEmployeeHRCenter);

            return employeeHRCenter;
        }
    }
}
