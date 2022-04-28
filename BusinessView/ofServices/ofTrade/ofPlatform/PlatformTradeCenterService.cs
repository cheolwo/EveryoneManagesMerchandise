﻿using BusinessView.ofTrade.ofPlatform;
using BusinessView.ofServices.ofTrade;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofTrade.ofPlatform
{
    public class PlatformTradeCenterService : TradeService, IDTOService<PlatformTradeCenter>
    {
        public PlatformTradeCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/PlatformTradeCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<PlatformTradeCenter?> GetAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<PlatformTradeCenter>($"/api/PlatformTradeCenter/{id}");
        }

        public async Task<IEnumerable<PlatformTradeCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<PlatformTradeCenter>>("/api/PlatformTradeCenter");
        }

        public async Task PostAsync(PlatformTradeCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/PlatformTradeCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }

        public async Task UpdateAsync(PlatformTradeCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/PlatformTradeCenter", entityJson);

            httpResponseMessage.EnsureSuccessStatusCode();
        }
    }
}
