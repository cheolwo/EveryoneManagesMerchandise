﻿using BusinessView.ofWarehouse.ofPlatform;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformIncomingTagService : WarehouseService, IDTOService<PlatformIncomingTag>
    {
        public PlatformIncomingTagService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformIncomingTag/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformIncomingTag?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformIncomingTag>($"/api/PlatformIncomingTag/{id}");
        }

        public async Task<IEnumerable<PlatformIncomingTag>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformIncomingTag>>("/api/PlatformIncomingTag");
        }

        public async Task<PlatformIncomingTag?> PostAsync(PlatformIncomingTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformIncomingTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformIncomingTag = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformIncomingTag? PlatformIncomingTag = JsonSerializer.Deserialize<PlatformIncomingTag>(JsonPlatformIncomingTag);
            return PlatformIncomingTag;
        }

        public async Task<PlatformIncomingTag?> PutAsync(PlatformIncomingTag entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformIncomingTag", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformIncomingTag = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformIncomingTag? PlatformIncomingTag = JsonSerializer.Deserialize<PlatformIncomingTag>(JsonPlatformIncomingTag);

            return PlatformIncomingTag;
        }
    }
}