using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerSPCommodityService : ProductService, IDTOService<EmployerSPCommodity>
    {
        public EmployerSPCommodityService(ProductServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerSPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerSPCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerSPCommodity>($"/api/EmployerSPCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerSPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerSPCommodity>>("/api/EmployerSPCommodity");
        }

        public async Task<EmployerSPCommodity?> PostAsync(EmployerSPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerSPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerSPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerSPCommodity? EmployerSPCommodity = JsonSerializer.Deserialize<EmployerSPCommodity>(JsonEmployerSPCommodity);
            return EmployerSPCommodity;
        }

        public async Task<EmployerSPCommodity?> PutAsync(EmployerSPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerSPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerSPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerSPCommodity? EmployerSPCommodity = JsonSerializer.Deserialize<EmployerSPCommodity>(JsonEmployerSPCommodity);

            return EmployerSPCommodity;
        }
    }
}
