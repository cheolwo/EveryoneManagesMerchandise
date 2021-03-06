using System.Reflection;
using System.Text.Json;
using System.ComponentModel.DataAnnotations;
using BusinessData.ofPresentationLayer.ofCommon;
using BusinessData.ofPresentationLayer.ofDTO.ofExternal;
using System.Net.Http;
using System;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace BusinessLogic.ofExternalManager.ofSearchingService
{
    public interface ICenterPageRoadAddressService
    {
        Task<List<string>> GetAddressByKeyword(string keyword);
    }
    public enum ErrorCodeKoreaSearchingAddressService
    {
        E0001, E0002, E0003, E0004, E0005, E0006, E0007, E0008, E0009, E0010, E0011, E0012, E0013, E0014, E0015
    }
    public class KoreaSearchingAddressService : ICenterPageRoadAddressService
    {
        public HttpClient _httpClient { get; set; }
        public KoreaSearchingAddressService()
        {
            _httpClient = new();
            _httpClient.BaseAddress = new Uri("https://www.juso.go.kr");
        }
        public async Task<List<string>> GetAddressByKeyword(string keyword)
        {
            KoreaAddressRequestParameter KoreaAddressRequestParameter = new(keyword);
            string requestUri = "/addrlink/addrLinkApiJsonp.do";
            string getUri = HttpClientExtensions.GetUri(requestUri, KoreaAddressRequestParameter);
            var HttpGetValue = await _httpClient.GetAsync(getUri);
            var Serialvalue = await HttpGetValue.Content.ReadAsStringAsync();
            var secondvalue = Serialvalue.Remove(0, 1);
            var ThirdValue = secondvalue.Remove(secondvalue.Length - 1, 1);

            var deserialvalue = JsonSerializer.Deserialize<Root>(ThirdValue);
            List<string> listAddress = new();
            foreach (var addr in deserialvalue.results.juso)
            {
                string value = Convert.ToString(addr.roadAddr);
                listAddress.Add(value);
            }
            return listAddress;
        }
        public async Task<HttpResponseMessage> SearchAddress(string Address)
        {
            KoreaAddressRequestParameter KoreaAddressRequestParameter = new(Address);
            string requestUri = "/addrlink/addrLinkApiJsonp.do";
            string getUri = HttpClientExtensions.GetUri(requestUri, KoreaAddressRequestParameter);
            return await _httpClient.GetAsync(getUri);
        }
        //public async Task<KoreadAddressExternalDTO> SearchAddress(string Address)
        //{
        //    KoreaAddressRequestParameter KoreaAddressRequestParameter = new(Address);
        //    string requestUri = "/addrlink/addrLinkApiJsonp.do";
        //    string getUri = HttpClientExtensions.GetUri(requestUri, KoreaAddressRequestParameter);
        //    return await _httpClient.GetFromJsonAsync<KoreadAddressExternalDTO>(getUri);
        //}
    }
    //devU01TX0FVVEgyMDIyMDUyMjE2NTUxNjExMjU5Nzg=
    public class KoreaAddressRequestParameter : IHttpRequestParameter
    {
        [Required] public int currentPage { get; set; } // ?????? ????????? ??????
        [Required] public int countPerPage { get; set; } // ???????????? ?????? ??? ?????? Row ???
        [Required] public string keyword { get; set; } // ?????? ?????????
        [Required] public string confmKey { get; set; } // ?????? ??? ???????????? ?????????
        public string resultType { get; set; }// ???????????? ?????? ?????? (?????? XML ??????) json?????? ??? Json ????????? ????????????
        public string hstryYn { get; set; } // 2020??? 12??? 8??? ????????? ?????? ????????? ???????????? ?????? ??????
        public string firstSort { get; set; } // ??????????????? none, ???????????? road
        public string addInfoYn { get; set; } // 2020??? 12??? 8??? ??? ????????? ???????????? ??????
        public KoreaAddressRequestParameter(string keyword)
        {
            this.keyword = keyword;
            currentPage = 1;
            countPerPage = 10;
            resultType = "json";
            firstSort = "none";
            confmKey = "devU01TX0FVVEgyMDIyMDUyMjE2NTUxNjExMjU5Nzg=";
            // etc....
        }
        public KoreaAddressRequestParameter(string keyword, string resultType)
        {
            this.keyword = keyword;
            currentPage = 1;
            countPerPage = 10;
            this.resultType = resultType;
            firstSort = "none";
        }
        public IEnumerable<PropertyInfo> GetRequiredProps()
        {
            var props = typeof(KoreaAddressRequestParameter).GetProperties();
            List<PropertyInfo> propertyInfos = new();
            foreach (var prop in props)
            {
                var Required = prop.GetCustomAttribute<RequiredAttribute>();
                if (Required is not null)
                {
                    propertyInfos.Add(prop);
                }
            }
            return propertyInfos;
        }
    }
}