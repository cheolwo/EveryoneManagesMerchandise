using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeProductCenterService : ProductService, IDTOService<EmployeeProductCenter>
    {
        public EmployeeProductCenterService(ProductServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeProductCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeProductCenter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeProductCenter>($"/api/EmployeeProductCenter/{id}");
        }

        public async Task<IEnumerable<EmployeeProductCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeProductCenter>>("/api/EmployeeProductCenter");
        }

        public async Task<EmployeeProductCenter?> PostAsync(EmployeeProductCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeProductCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeProductCenter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeProductCenter? EmployeeProductCenter = JsonSerializer.Deserialize<EmployeeProductCenter>(JsonEmployeeProductCenter);
            return EmployeeProductCenter;
        }

        public async Task<EmployeeProductCenter?> PutAsync(EmployeeProductCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeProductCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeProductCenter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeProductCenter? EmployeeProductCenter = JsonSerializer.Deserialize<EmployeeProductCenter>(JsonEmployeeProductCenter);

            return EmployeeProductCenter;
        }
    }
}
