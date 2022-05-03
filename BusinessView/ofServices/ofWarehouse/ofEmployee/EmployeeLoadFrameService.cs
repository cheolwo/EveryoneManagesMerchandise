using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeLoadFrameService : WarehouseService, IDTOService<EmployeeLoadFrame>
    {
        public EmployeeLoadFrameService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeLoadFrame/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeLoadFrame?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeLoadFrame>($"/api/EmployeeLoadFrame/{id}");
        }

        public async Task<IEnumerable<EmployeeLoadFrame>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeLoadFrame>>("/api/EmployeeLoadFrame");
        }

        public async Task<EmployeeLoadFrame?> PostAsync(EmployeeLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeLoadFrame", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeLoadFrame = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeLoadFrame? EmployeeLoadFrame = JsonSerializer.Deserialize<EmployeeLoadFrame>(JsonEmployeeLoadFrame);
            return EmployeeLoadFrame;
        }

        public async Task<EmployeeLoadFrame?> PutAsync(EmployeeLoadFrame entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeLoadFrame", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeLoadFrame = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeLoadFrame? EmployeeLoadFrame = JsonSerializer.Deserialize<EmployeeLoadFrame>(JsonEmployeeLoadFrame);

            return EmployeeLoadFrame;
        }
    }
}
