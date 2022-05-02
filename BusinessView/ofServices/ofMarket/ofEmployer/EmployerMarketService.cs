﻿using BusinessView.ofMarket.ofEmployer;
using BusinessView.ofServices.ofMarket;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerMarketService : MarketService, IDTOService<EmployerMarket>
    {
        public EmployerMarketService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployerMarket/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployerMarket?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployerMarket>($"/api/EmployerMarket/{id}");
        }

        public async Task<IEnumerable<EmployerMarket>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployerMarket>>("/api/EmployerMarket");
        }

        public async Task<EmployerMarket?> PostAsync(EmployerMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployerMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMarket = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployerMarket? EmployerMarket = JsonSerializer.Deserialize<EmployerMarket>(JsonEmployerMarket);
            return EmployerMarket;
        }

        public async Task<EmployerMarket?> PutAsync(EmployerMarket entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployerMarket", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployerMarket = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployerMarket? EmployerMarket = JsonSerializer.Deserialize<EmployerMarket>(JsonEmployerMarket);

            return EmployerMarket;
        }
    }
}
