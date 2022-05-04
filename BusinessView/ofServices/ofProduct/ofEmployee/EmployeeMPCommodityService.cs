﻿using BusinessView.ofDTO.ofProduct.ofEmployee;
using BusinessView.ofServices.ofProduct;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeMPCommodityService : ProductService, IDTOService<EmployeeMPCommodity>
    {
        public EmployeeMPCommodityService(ProductServiceOptions options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeMPCommodity/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeMPCommodity?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeMPCommodity>($"/api/EmployeeMPCommodity/{id}");
        }

        public async Task<IEnumerable<EmployeeMPCommodity>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeMPCommodity>>("/api/EmployeeMPCommodity");
        }

        public async Task<EmployeeMPCommodity?> PostAsync(EmployeeMPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeMPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeMPCommodity? EmployeeMPCommodity = JsonSerializer.Deserialize<EmployeeMPCommodity>(JsonEmployeeMPCommodity);
            return EmployeeMPCommodity;
        }

        public async Task<EmployeeMPCommodity?> PutAsync(EmployeeMPCommodity entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeMPCommodity", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeMPCommodity = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeMPCommodity? EmployeeMPCommodity = JsonSerializer.Deserialize<EmployeeMPCommodity>(JsonEmployeeMPCommodity);

            return EmployeeMPCommodity;
        }
    }
}
