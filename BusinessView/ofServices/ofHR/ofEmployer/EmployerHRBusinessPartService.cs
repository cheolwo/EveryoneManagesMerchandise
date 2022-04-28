using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofDTO.ofHRDTO.ofEmployer;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployer
{
    public class EmployerHRBusinessPartService : HRService, IDTOService<EmployerHRBusinessPart>
    {
        public EmployerHRBusinessPartService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerHRBusinessPart/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerHRBusinessPart?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerHRBusinessPart>($"/api/EmployerHRBusinessPart/{id}");
        }

        public async Task<IEnumerable<EmployerHRBusinessPart>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerHRBusinessPart>>("/api/EmployerHRBusinessPart");
        }

        public async Task PostAsync(EmployerHRBusinessPart entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerHRBusinessPart", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerHRBusinessPart entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerHRBusinessPart", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
