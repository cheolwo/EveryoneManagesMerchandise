using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployeeHRBusinessPartService : HRService, IDTOService<EmployeeHRBusinessPart>
    {
        public EmployeeHRBusinessPartService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeHRBusinessPart/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeHRBusinessPart?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeHRBusinessPart>($"/api/EmployeeHRBusinessPart/{id}");
        }

        public async Task<IEnumerable<EmployeeHRBusinessPart>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeHRBusinessPart>>("/api/EmployeeHRBusinessPart");
        }

        public async Task<EmployeeHRBusinessPart?> PostAsync(EmployeeHRBusinessPart entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeHRBusinessPart", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeHRBusinessPart = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeHRBusinessPart? EmployeeHRBusinessPart = JsonSerializer.Deserialize<EmployeeHRBusinessPart>(JsonEmployeeHRBusinessPart);
            return EmployeeHRBusinessPart;
        }

        public async Task<EmployeeHRBusinessPart?> PutAsync(EmployeeHRBusinessPart entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeHRBusinessPart", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeHRBusinessPart = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeHRBusinessPart? EmployeeHRBusinessPart = JsonSerializer.Deserialize<EmployeeHRBusinessPart>(JsonEmployeeHRBusinessPart);

            return EmployeeHRBusinessPart;
        }
    }
}
