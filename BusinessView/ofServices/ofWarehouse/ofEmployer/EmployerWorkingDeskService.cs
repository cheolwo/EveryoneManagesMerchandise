using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerWorkingDeskService : WarehouseService, IDTOService<EmployerWorkingDesk>
    {
        public EmployerWorkingDeskService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerWorkingDesk/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerWorkingDesk?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerWorkingDesk>($"/api/EmployerWorkingDesk/{id}");
        }

        public async Task<IEnumerable<EmployerWorkingDesk>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerWorkingDesk>>("/api/EmployerWorkingDesk");
        }

        public async Task<EmployerWorkingDesk?> PostAsync(EmployerWorkingDesk entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerWorkingDesk", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerWorkingDesk = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerWorkingDesk? EmployerWorkingDesk = JsonSerializer.Deserialize<EmployerWorkingDesk>(JsonEmployerWorkingDesk);
            return EmployerWorkingDesk;
        }

        public async Task<EmployerWorkingDesk?> PutAsync(EmployerWorkingDesk entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerWorkingDesk", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerWorkingDesk = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerWorkingDesk? EmployerWorkingDesk = JsonSerializer.Deserialize<EmployerWorkingDesk>(JsonEmployerWorkingDesk);

            return EmployerWorkingDesk;
        }
    }
}
