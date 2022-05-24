﻿using AutoMapper;
using BusinessData;
using BusinessView.ofGeneric;
using BusinessView.ofViewModels.ofWebApp.ofCommon;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices
{
    public interface IDTOService<T> where T : class
    {
        Task<IEnumerable<T>?> GetsAsync();
        Task<T?> GetByIdAsync(string id);
        Task<T?> PostAsync(T entity);
        Task DeleteAsync(string id);
        Task<T?> PutAsync(T entity);
    }
    public class DTOServiceOptions
    {
        public bool IsDevelopment = true;
    }
    public class DTOService
    {
        protected HttpClient _httpClient = new();
        protected DTOServiceOptions _DTOServiceOptions;
        public DTOService(DTOServiceOptions options)
        {
            _DTOServiceOptions = options;
            
        }
        public virtual async Task<T?> PostAsync<T>(T t, MultipartFormDataContent content) where T : new()
        {
            var entityJson = new StringContent(
                            JsonSerializer.Serialize(t),
                            Encoding.UTF8,
                            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            using var httpResponseMessage =
               await _httpClient.PostAsync($"/api/{typeof(T).Name}", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            var response = await _httpClient.PostAsync("/api/Filesave", content);
            if (response.IsSuccessStatusCode)
            {
                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true,
                };

                using var responseStream =
                    await response.Content.ReadAsStreamAsync();

                var newUploadResults = await JsonSerializer
                    .DeserializeAsync<IList<UploadResult>>(responseStream, options);

                Console.WriteLine(newUploadResults);
            }

            string JsonIdentityUserDTO = await httpResponseMessage.Content.ReadAsStringAsync();
            T? dto = JsonSerializer.Deserialize<T>(JsonIdentityUserDTO);
            return dto;
        }
        public virtual async Task<T?> PostAsync<T>(T t) where T :  class, new()
        {
            AutoMapAttribute? autoMapAttribute = (AutoMapAttribute?)Attribute.GetCustomAttribute(typeof(T), typeof(AutoMapAttribute));
            if(autoMapAttribute == null ) { throw new ArgumentException("NOT_INCLUDE_ORIGINATTRIBUTE"); }
            var entityJson = new StringContent(
                            JsonSerializer.Serialize(t),
                            Encoding.UTF8,
                            Application.Json); // using static System.Net.Mime.MediaTypeNames;

            //var configuration = new MapperConfiguration(cfg => cfg.AddMaps("BusinessView"));
            //var mapper = new Mapper(configuration);

            using var httpResponseMessage =
               await _httpClient.PostAsync($"/api/{typeof(T).Name}", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();
            var value = await httpResponseMessage.Content.ReadFromJsonAsync<T>();
            return value;
        }
        public virtual async Task<T?> PutAsync<T>(T t) where T : new()
        {
            var entityJson = new StringContent(
            JsonSerializer.Serialize(t),
            Encoding.UTF8,
            Application.Json); // using static System.Net.Mime.MediaTypeNames;
            using var httpResponseMessage =
               await _httpClient.PutAsync($"/api/{typeof(T).Name}", entityJson);
            httpResponseMessage.EnsureSuccessStatusCode();

            string JsonIdentityUserDTO = await httpResponseMessage.Content.ReadAsStringAsync();
            T? dto = JsonSerializer.Deserialize<T>(JsonIdentityUserDTO);
            return dto;
        }
        public virtual async Task DeleteAsync<T>(string id) where T : new()
        {
            var Response = await _httpClient.DeleteAsync($"api/{typeof(T).Name}/{id}");
            Response.EnsureSuccessStatusCode();
        }
        public virtual async Task<T?> GetByIdAsync<T>(string id) where T : new()
        {
            return await _httpClient.GetFromJsonAsync<T>($"/api/{typeof(T).Name}/{id}");
        }
        public virtual async Task<IEnumerable<T>?> GetsAsync<T>() where T : new()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<T>?>($"/api/{typeof(T).Name}");
        }
        public virtual async Task<IEnumerable<T>?> GetsAsyncByUserId<T>(string userid) where T : new()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<T>?>($"/api/{typeof(T).Name}/User?{userid}");
        }
    }
    //public class DTOService
    //{
    //    protected HttpClient _httpClient = new();
    //    private DTOServiceOptions _options = new();
    //    public DTOService(Action<DTOServiceOptions> options)
    //    {
    //        options.Invoke(_options);
    //    }
    //}

}
