using BusinessView.ofProduct.ofEmployee;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofProduct.ofEmployee
{
    public class EmployeeEPCommodityService : ProductService, IDTOService<EmployeeEPCommodity>
    {
        public EmployeeEPCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeEPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeEPCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeEPCommodity>($"/api/EmployeeEPCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeEPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeEPCommodity>>("/api/EmployeeEPCommodity");
        }

        public async Task PostAsync(EmployeeEPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeEPCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployeeEPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeEPCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
