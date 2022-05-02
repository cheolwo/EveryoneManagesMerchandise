﻿using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformETCommodityService : TradeService, IDTOService<PlatformETCommodity>
    {
        public PlatformETCommodityService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformETCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformETCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformETCommodity>($"/api/PlatformETCommodity/{id}");
        }

        public async Task<IEnumerable<PlatformETCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformETCommodity>>("/api/PlatformETCommodity");
        }

        public async Task<PlatformETCommodity?> PostAsync(PlatformETCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformETCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformETCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            PlatformETCommodity? PlatformETCommodity = JsonSerializer.Deserialize<PlatformETCommodity>(JsonPlatformETCommodity);
            return PlatformETCommodity;
        }

        public async Task<PlatformETCommodity?> PutAsync(PlatformETCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformETCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonPlatformETCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            PlatformETCommodity? PlatformETCommodity = JsonSerializer.Deserialize<PlatformETCommodity>(JsonPlatformETCommodity);

            return PlatformETCommodity;
        }
    }
}