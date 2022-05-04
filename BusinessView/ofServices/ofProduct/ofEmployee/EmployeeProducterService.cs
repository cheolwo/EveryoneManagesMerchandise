using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeProducterService : ProductService, IDTOService<EmployeeProducter>
    {
        public EmployeeProducterService(ProductServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeProducter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeProducter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeProducter>($"/api/EmployeeProducter/{id}");
        }

        public async Task<IEnumerable<EmployeeProducter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeProducter>>("/api/EmployeeProducter");
        }

        public async Task<EmployeeProducter?> PostAsync(EmployeeProducter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeProducter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeProducter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeProducter? EmployeeProducter = JsonSerializer.Deserialize<EmployeeProducter>(JsonEmployeeProducter);
            return EmployeeProducter;
        }

        public async Task<EmployeeProducter?> PutAsync(EmployeeProducter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeProducter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeProducter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeProducter? EmployeeProducter = JsonSerializer.Deserialize<EmployeeProducter>(JsonEmployeeProducter);

            return EmployeeProducter;
        }
    }
}
