using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofProduct.ofEmployer
{
    public class EmployerPCommodityService : ProductService, IDTOService<EmployerPCommodity>
    {
        public EmployerPCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerPCommodity?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerPCommodity>($"/api/EmployerPCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerPCommodity>>("/api/EmployerPCommodity");
        }

        public async Task PostAsync(EmployerPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerPCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerPCommodity", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
