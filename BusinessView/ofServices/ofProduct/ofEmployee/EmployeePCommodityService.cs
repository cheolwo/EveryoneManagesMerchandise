using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeePCommodityService : ProductService, IDTOService<EmployeePCommodity>
    {
        public EmployeePCommodityService(ProductServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeePCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeePCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeePCommodity>($"/api/EmployeePCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeePCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeePCommodity>>("/api/EmployeePCommodity");
        }

        public async Task<EmployeePCommodity?> PostAsync(EmployeePCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeePCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeePCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeePCommodity? EmployeePCommodity = JsonSerializer.Deserialize<EmployeePCommodity>(JsonEmployeePCommodity);
            return EmployeePCommodity;
        }

        public async Task<EmployeePCommodity?> PutAsync(EmployeePCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeePCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeePCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeePCommodity? EmployeePCommodity = JsonSerializer.Deserialize<EmployeePCommodity>(JsonEmployeePCommodity);

            return EmployeePCommodity;
        }
    }
}
