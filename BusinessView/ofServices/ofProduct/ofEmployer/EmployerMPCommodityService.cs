using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerMPCommodityService : ProductService, IDTOService<EmployerMPCommodity>
    {
        public EmployerMPCommodityService(ProductServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMPCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMPCommodity>($"/api/EmployerMPCommodity/{id}");
        }

        public async Task<IEnumerable<EmployerMPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMPCommodity>>("/api/EmployerMPCommodity");
        }

        public async Task<EmployerMPCommodity?> PostAsync(EmployerMPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerMPCommodity? EmployerMPCommodity = JsonSerializer.Deserialize<EmployerMPCommodity>(JsonEmployerMPCommodity);
            return EmployerMPCommodity;
        }

        public async Task<EmployerMPCommodity?> PutAsync(EmployerMPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerMPCommodity? EmployerMPCommodity = JsonSerializer.Deserialize<EmployerMPCommodity>(JsonEmployerMPCommodity);

            return EmployerMPCommodity;
        }
    }
}
