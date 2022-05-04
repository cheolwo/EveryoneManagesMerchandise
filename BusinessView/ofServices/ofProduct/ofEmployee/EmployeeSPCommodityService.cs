using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeSPCommodityService : ProductService, IDTOService<EmployeeSPCommodity>
    {
        public EmployeeSPCommodityService(ProductServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeSPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeSPCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeSPCommodity>($"/api/EmployeeSPCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeSPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeSPCommodity>>("/api/EmployeeSPCommodity");
        }

        public async Task<EmployeeSPCommodity?> PostAsync(EmployeeSPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeSPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeSPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeSPCommodity? EmployeeSPCommodity = JsonSerializer.Deserialize<EmployeeSPCommodity>(JsonEmployeeSPCommodity);
            return EmployeeSPCommodity;
        }

        public async Task<EmployeeSPCommodity?> PutAsync(EmployeeSPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeSPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeSPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeSPCommodity? EmployeeSPCommodity = JsonSerializer.Deserialize<EmployeeSPCommodity>(JsonEmployeeSPCommodity);

            return EmployeeSPCommodity;
        }
    }
}
