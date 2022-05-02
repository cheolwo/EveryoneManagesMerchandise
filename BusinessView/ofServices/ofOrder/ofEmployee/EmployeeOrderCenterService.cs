﻿using BusinessView.ofOrder.ofEmployee;
using BusinessView.ofServices.ofOrder;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeOrderCenterService : OrderService, IDTOService<EmployeeOrderCenter>
    {
        public EmployeeOrderCenterService(Action<DTOServiceOptions> options)
            : base(options)
        {

        }

        public async Task DeleteAsync(string id)
        {
            var Response = await _httpClient.DeleteAsync($"api/EmployeeOrderCenter/{id}");
            Response.EnsureSuccessStatusCode();
        }

        public async Task<EmployeeOrderCenter?> GetByIdAsync(string id)
        {
            return await _httpClient.GetFromJsonAsync<EmployeeOrderCenter>($"/api/EmployeeOrderCenter/{id}");
        }

        public async Task<IEnumerable<EmployeeOrderCenter>?> GetsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<EmployeeOrderCenter>>("/api/EmployeeOrderCenter");
        }

        public async Task<EmployeeOrderCenter?> PostAsync(EmployeeOrderCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PostAsync("/api/EmployeeOrderCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeOrderCenter = await httpResponseMessage.Content.ReadAsStringAsync();
            EmployeeOrderCenter? EmployeeOrderCenter = JsonSerializer.Deserialize<EmployeeOrderCenter>(JsonEmployeeOrderCenter);
            return EmployeeOrderCenter;
        }

        public async Task<EmployeeOrderCenter?> PutAsync(EmployeeOrderCenter entity)
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(entity),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
                await _httpClient.PutAsync("/api/EmployeeOrderCenter", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonEmployeeOrderCenter = await httpResponseMessage.Content.ReadAsStringAsync();

            EmployeeOrderCenter? EmployeeOrderCenter = JsonSerializer.Deserialize<EmployeeOrderCenter>(JsonEmployeeOrderCenter);

            return EmployeeOrderCenter;
        }
    }
}
