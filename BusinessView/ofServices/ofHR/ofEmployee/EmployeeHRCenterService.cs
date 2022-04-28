using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeHRCenterService : HRService, IDTOService<EmployeeHRCenter>
    {
        public EmployeeHRCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeHRCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeHRCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeHRCenter>($"/api/EmployeeHRCenter/{id}");
        }

        public async Task<IEnumerable<EmployeeHRCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeHRCenter>>("/api/EmployeeHRCenter");
        }

        public async Task PostAsync(EmployeeHRCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeHRCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeHRCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeHRCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
