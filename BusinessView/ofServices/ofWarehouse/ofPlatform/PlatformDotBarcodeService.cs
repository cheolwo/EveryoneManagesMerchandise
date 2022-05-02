using BusinessView.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformDotBarcodeService : WarehouseService, IDTOService<PlatformDotBarcode>
    {
        public PlatformDotBarcodeService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformDotBarcode/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformDotBarcode?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformDotBarcode>($"/api/PlatformDotBarcode/{id}");
        }

        public async Task<IEnumerable<PlatformDotBarcode>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformDotBarcode>>("/api/PlatformDotBarcode");
        }

        public async Task<PlatformDotBarcode?> PostAsync(PlatformDotBarcode entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformDotBarcode", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformDotBarcode = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformDotBarcode? PlatformDotBarcode = JsonSerializer.Deserialize<PlatformDotBarcode>(JsonPlatformDotBarcode);
            return PlatformDotBarcode;
        }

        public async Task<PlatformDotBarcode?> PutAsync(PlatformDotBarcode entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformDotBarcode", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformDotBarcode = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformDotBarcode? PlatformDotBarcode = JsonSerializer.Deserialize<PlatformDotBarcode>(JsonPlatformDotBarcode);

            return PlatformDotBarcode;
        }
    }
}
