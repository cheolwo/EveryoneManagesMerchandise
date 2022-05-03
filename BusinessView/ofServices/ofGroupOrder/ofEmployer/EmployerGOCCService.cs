using BusinessView.ofDTO.ofGroupOrder.ofEmployer;
using BusinessView.ofServices.ofGroupOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofGroupOrder.ofEmployer
{
    public class EmployerGOCCService : GroupOrderService, IDTOService<EmployerGOCC>
    {
        public EmployerGOCCService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerGOCC/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerGOCC?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerGOCC>($"/api/EmployerGOCC/{id}");
        }

        public async Task<IEnumerable<EmployerGOCC>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerGOCC>>("/api/EmployerGOCC");
        }

        public async Task<EmployerGOCC?> PostAsync(EmployerGOCC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerGOCC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerGOCC = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerGOCC? EmployerGOCC = JsonSerializer.Deserialize<EmployerGOCC>(JsonEmployerGOCC);
            return EmployerGOCC;
        }

        public async Task<EmployerGOCC?> PutAsync(EmployerGOCC entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerGOCC", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerGOCC = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerGOCC? EmployerGOCC = JsonSerializer.Deserialize<EmployerGOCC>(JsonEmployerGOCC);

            return EmployerGOCC;
        }
    }
}
