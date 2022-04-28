using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofProduct.ofEmployer
{
    public class EmployerEPCommodityService : ProductService, IDTOService<EmployerEPCommodity>
    {
        public EmployerEPCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerEPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerEPCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerEPCommodity>($"/api/EmployerEPCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerEPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerEPCommodity>>("/api/EmployerEPCommodity");
        }

        public async Task PostAsync(EmployerEPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerEPCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerEPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerEPCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
