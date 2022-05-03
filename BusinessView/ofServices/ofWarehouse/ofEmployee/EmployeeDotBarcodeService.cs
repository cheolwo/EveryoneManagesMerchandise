using BusinessView.ofDTO.ofWarehouse.ofEmployee;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeDotBarcodeService : WarehouseService, IDTOService<EmployeeDotBarcode>
    {
        public EmployeeDotBarcodeService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeDotBarcode/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeDotBarcode?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeDotBarcode>($"/api/EmployeeDotBarcode/{id}");
        }

        public async Task<IEnumerable<EmployeeDotBarcode>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeDotBarcode>>("/api/EmployeeDotBarcode");
        }

        public async Task<EmployeeDotBarcode?> PostAsync(EmployeeDotBarcode entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeDotBarcode", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeDotBarcode = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeDotBarcode? EmployeeDotBarcode = JsonSerializer.Deserialize<EmployeeDotBarcode>(JsonEmployeeDotBarcode);
            return EmployeeDotBarcode;
        }

        public async Task<EmployeeDotBarcode?> PutAsync(EmployeeDotBarcode entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeDotBarcode", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeDotBarcode = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeDotBarcode? EmployeeDotBarcode = JsonSerializer.Deserialize<EmployeeDotBarcode>(JsonEmployeeDotBarcode);

            return EmployeeDotBarcode;
        }
    }
}
