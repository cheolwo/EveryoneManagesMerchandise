using BusinessView.ofDTO.ofProduct.ofEmployer;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerProducterService : ProductService, IDTOService<EmployerProducter>
    {
        public EmployerProducterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerProducter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerProducter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerProducter>($"/api/EmployerProducter/{id}");
        }

        public async Task<IEnumerable<EmployerProducter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerProducter>>("/api/EmployerProducter");
        }

        public async Task<EmployerProducter?> PostAsync(EmployerProducter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerProducter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerProducter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerProducter? EmployerProducter = JsonSerializer.Deserialize<EmployerProducter>(JsonEmployerProducter);
            return EmployerProducter;
        }

        public async Task<EmployerProducter?> PutAsync(EmployerProducter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerProducter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerProducter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerProducter? EmployerProducter = JsonSerializer.Deserialize<EmployerProducter>(JsonEmployerProducter);

            return EmployerProducter;
        }
    }
}
