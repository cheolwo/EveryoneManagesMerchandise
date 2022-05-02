using BusinessView.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerLoadFrameService : WarehouseService, IDTOService<EmployerLoadFrame>
    {
        public EmployerLoadFrameService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerLoadFrame/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerLoadFrame?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerLoadFrame>($"/api/EmployerLoadFrame/{id}");
        }

        public async Task<IEnumerable<EmployerLoadFrame>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerLoadFrame>>("/api/EmployerLoadFrame");
        }

        public async Task<EmployerLoadFrame?> PostAsync(EmployerLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerLoadFrame", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerLoadFrame = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerLoadFrame? EmployerLoadFrame = JsonSerializer.Deserialize<EmployerLoadFrame>(JsonEmployerLoadFrame);
            return EmployerLoadFrame;
        }

        public async Task<EmployerLoadFrame?> PutAsync(EmployerLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerLoadFrame", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerLoadFrame = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerLoadFrame? EmployerLoadFrame = JsonSerializer.Deserialize<EmployerLoadFrame>(JsonEmployerLoadFrame);

            return EmployerLoadFrame;
        }
    }
}
