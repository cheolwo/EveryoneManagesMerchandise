using BusinessView.ofOrder.ofEmployer;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofOrder.ofEmployer
{
    public class EmployerOrderCenterService : OrderService, IDTOService<EmployerOrderCenter>
    {
        public EmployerOrderCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerOrderCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerOrderCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerOrderCenter>($"/api/EmployerOrderCenter/{id}");
        }

        public async Task<IEnumerable<EmployerOrderCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerOrderCenter>>("/api/EmployerOrderCenter");
        }

        public async Task PostAsync(EmployerOrderCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerOrderCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(EmployerOrderCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerOrderCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
