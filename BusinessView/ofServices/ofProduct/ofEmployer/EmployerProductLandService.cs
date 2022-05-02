using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerProductLandService : ProductService, IDTOService<EmployerProductLand>
    {
        public EmployerProductLandService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerProductLand/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerProductLand?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerProductLand>($"/api/EmployerProductLand/{id}");
        }

        public async Task<IEnumerable<EmployerProductLand>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerProductLand>>("/api/EmployerProductLand");
        }

        public async Task<EmployerProductLand?> PostAsync(EmployerProductLand entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerProductLand", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerProductLand = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerProductLand? EmployerProductLand = JsonSerializer.Deserialize<EmployerProductLand>(JsonEmployerProductLand);
            return EmployerProductLand;
        }

        public async Task<EmployerProductLand?> PutAsync(EmployerProductLand entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerProductLand", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerProductLand = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerProductLand? EmployerProductLand = JsonSerializer.Deserialize<EmployerProductLand>(JsonEmployerProductLand);

            return EmployerProductLand;
        }
    }
}
