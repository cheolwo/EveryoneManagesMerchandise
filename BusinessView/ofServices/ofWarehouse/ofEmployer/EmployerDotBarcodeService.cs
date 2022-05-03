using BusinessView.ofDTO.ofWarehouse.ofEmployer;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerDotBarcodeService : WarehouseService, IDTOService<EmployerDotBarcode>
    {
        public EmployerDotBarcodeService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerDotBarcode/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerDotBarcode?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerDotBarcode>($"/api/EmployerDotBarcode/{id}");
        }

        public async Task<IEnumerable<EmployerDotBarcode>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerDotBarcode>>("/api/EmployerDotBarcode");
        }

        public async Task<EmployerDotBarcode?> PostAsync(EmployerDotBarcode entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerDotBarcode", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerDotBarcode = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerDotBarcode? EmployerDotBarcode = JsonSerializer.Deserialize<EmployerDotBarcode>(JsonEmployerDotBarcode);
            return EmployerDotBarcode;
        }

        public async Task<EmployerDotBarcode?> PutAsync(EmployerDotBarcode entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerDotBarcode", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerDotBarcode = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerDotBarcode? EmployerDotBarcode = JsonSerializer.Deserialize<EmployerDotBarcode>(JsonEmployerDotBarcode);

            return EmployerDotBarcode;
        }
    }
}
