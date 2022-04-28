﻿using BusinessView.ofDTO.ofHRDTO;
using BusinessView.ofDTO.ofHRDTO.ofEmployee;
using BusinessView.ofDTO.ofHRDTO.ofPlatform;
using BusinessView.ofServices.ofHR;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofHR.ofPlatform
{
    public class PlatformHRCenterService : HRService, IDTOService<PlatformHRCenter>
    {
        public PlatformHRCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformHRCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformHRCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformHRCenter>($"/api/PlatformHRCenter/{id}");
        }

        public async Task<IEnumerable<PlatformHRCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformHRCenter>>("/api/PlatformHRCenter");
        }

        public async Task PostAsync(PlatformHRCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformHRCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformHRCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformHRCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
