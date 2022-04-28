using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofProduct.ofEmployee
{
    public class EmployeeProducterService : ProductService, IDTOService<EmployeeProducter>
    {
        public EmployeeProducterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeProducter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeProducter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeProducter>($"/api/EmployeeProducter/{id}");
        }

        public async Task<IEnumerable<EmployeeProducter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeProducter>>("/api/EmployeeProducter");
        }

        public async Task PostAsync(EmployeeProducter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeProducter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeProducter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeProducter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
