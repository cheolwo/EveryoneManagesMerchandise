using BusinessView.ofDTO.ofHR.ofPlatform;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofEmployee
{
    public class PlatformHRBusinessPartService : HRService, IDTOService<PlatformHRBusinessPart>
    {
        public PlatformHRBusinessPartService(HRServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformHRBusinessPart/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformHRBusinessPart?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformHRBusinessPart>($"/api/PlatformHRBusinessPart/{id}");
        }

        public async Task<IEnumerable<PlatformHRBusinessPart>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformHRBusinessPart>>("/api/PlatformHRBusinessPart");
        }

        public async Task<PlatformHRBusinessPart?> PostAsync(PlatformHRBusinessPart entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformHRBusinessPart", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformHRBusinessPart = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformHRBusinessPart? PlatformHRBusinessPart = JsonSerializer.Deserialize<PlatformHRBusinessPart>(JsonPlatformHRBusinessPart);
            return PlatformHRBusinessPart;
        }

        public async Task<PlatformHRBusinessPart?> PutAsync(PlatformHRBusinessPart entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformHRBusinessPart", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformHRBusinessPart = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformHRBusinessPart? PlatformHRBusinessPart = JsonSerializer.Deserialize<PlatformHRBusinessPart>(JsonPlatformHRBusinessPart);

            return PlatformHRBusinessPart;
        }
    }
}
