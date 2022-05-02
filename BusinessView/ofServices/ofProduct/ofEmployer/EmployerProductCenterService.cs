using BusinessView.ofProduct.ofEmployer;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerProductCenterService : ProductService, IDTOService<EmployerProductCenter>
    {
        public EmployerProductCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerProductCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerProductCenter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerProductCenter>($"/api/EmployerProductCenter/{id}");
        }

        public async Task<IEnumerable<EmployerProductCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerProductCenter>>("/api/EmployerProductCenter");
        }

        public async Task<EmployerProductCenter?> PostAsync(EmployerProductCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerProductCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerProductCenter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerProductCenter? EmployerProductCenter = JsonSerializer.Deserialize<EmployerProductCenter>(JsonEmployerProductCenter);
            return EmployerProductCenter;
        }

        public async Task<EmployerProductCenter?> PutAsync(EmployerProductCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerProductCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerProductCenter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerProductCenter? EmployerProductCenter = JsonSerializer.Deserialize<EmployerProductCenter>(JsonEmployerProductCenter);

            return EmployerProductCenter;
        }
    }
}
