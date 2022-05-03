using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeProductLandService : ProductService, IDTOService<EmployeeProductLand>
    {
        public EmployeeProductLandService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeProductLand/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeProductLand?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeProductLand>($"/api/EmployeeProductLand/{id}");
        }

        public async Task<IEnumerable<EmployeeProductLand>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeProductLand>>("/api/EmployeeProductLand");
        }

        public async Task<EmployeeProductLand?> PostAsync(EmployeeProductLand entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeProductLand", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeProductLand = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeProductLand? EmployeeProductLand = JsonSerializer.Deserialize<EmployeeProductLand>(JsonEmployeeProductLand);
            return EmployeeProductLand;
        }

        public async Task<EmployeeProductLand?> PutAsync(EmployeeProductLand entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeProductLand", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeProductLand = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeProductLand? EmployeeProductLand = JsonSerializer.Deserialize<EmployeeProductLand>(JsonEmployeeProductLand);

            return EmployeeProductLand;
        }
    }
}
