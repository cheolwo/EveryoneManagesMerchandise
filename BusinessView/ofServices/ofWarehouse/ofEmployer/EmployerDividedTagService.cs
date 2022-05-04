using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerDividedTagService : WarehouseService, IDTOService<EmployerDividedTag>
    {
        public EmployerDividedTagService(WarehouseServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerDividedTag/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerDividedTag?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerDividedTag>($"/api/EmployerDividedTag/{id}");
        }

        public async Task<IEnumerable<EmployerDividedTag>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerDividedTag>>("/api/EmployerDividedTag");
        }

        public async Task<EmployerDividedTag?> PostAsync(EmployerDividedTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerDividedTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerDividedTag = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerDividedTag? EmployerDividedTag = JsonSerializer.Deserialize<EmployerDividedTag>(JsonEmployerDividedTag);
            return EmployerDividedTag;
        }

        public async Task<EmployerDividedTag?> PutAsync(EmployerDividedTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerDividedTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerDividedTag = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerDividedTag? EmployerDividedTag = JsonSerializer.Deserialize<EmployerDividedTag>(JsonEmployerDividedTag);

            return EmployerDividedTag;
        }
    }
}
