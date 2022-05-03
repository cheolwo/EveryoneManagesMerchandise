using BusinessView.ofDTO.ofHR.ofEmployer;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class EmployerHRCenterService : HRService, IDTOService<EmployerHRCenter>
    {
        public EmployerHRCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerHRCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerHRCenter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerHRCenter>($"/api/EmployerHRCenter/{id}");
        }

        public async Task<IEnumerable<EmployerHRCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerHRCenter>>("/api/EmployerHRCenter");
        }

        public async Task<EmployerHRCenter?> PostAsync(EmployerHRCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerHRCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerHRCenter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerHRCenter? EmployerHRCenter = JsonSerializer.Deserialize<EmployerHRCenter>(JsonEmployerHRCenter);
            return EmployerHRCenter;
        }

        public async Task<EmployerHRCenter?> PutAsync(EmployerHRCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerHRCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerHRCenter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerHRCenter? EmployerHRCenter = JsonSerializer.Deserialize<EmployerHRCenter>(JsonEmployerHRCenter);

            return EmployerHRCenter;
        }
    }
}
