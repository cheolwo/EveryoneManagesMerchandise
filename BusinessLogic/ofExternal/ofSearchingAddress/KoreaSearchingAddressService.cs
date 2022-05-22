using System.Reflection;
using System;
using BusinessLogic.ofExternal.ofCommon;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace BusinessLogic.ofExternal.ofSearchingService
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
    public class KoreadAddressExternalDTO
    {
        public Common Common = new();
        public List<Juso> Jusos = new();
    }
    public class Common
    {
        public dynamic errorMessage { get; set; }
        public dynamic countPerPage { get; set; }
        public dynamic totalCount { get; set; }
        public dynamic errorCode { get; set; }
        public dynamic currentPage { get; set; }
    }

    public class Juso
    {
        public dynamic detBdNmList { get; set; }
        public dynamic engAddr { get; set; }
        public dynamic rn { get; set; }
        public dynamic emdNm { get; set; }
        public dynamic zipNo { get; set; }
        public dynamic roadAddrPart2 { get; set; }
        public dynamic emdNo { get; set; }
        public dynamic sggNm { get; set; }
        public dynamic jibunAddr { get; set; }
        public dynamic siNm { get; set; }
        public dynamic roadAddrPart1 { get; set; }
        public dynamic bdNm { get; set; }
        public dynamic admCd { get; set; }
        public dynamic udrtYn { get; set; }
        public dynamic lnbrMnnm { get; set; }
        public dynamic roadAddr { get; set; }
        public dynamic lnbrSlno { get; set; }
        public dynamic buldMnnm { get; set; }
        public dynamic bdKdcd { get; set; }
        public dynamic liNm { get; set; }
        public dynamic rnMgtSn { get; set; }
        public dynamic mtYn { get; set; }
        public dynamic bdMgtSn { get; set; }
        public dynamic buldSlno { get; set; }
    }

    public class Results
    {
        public Common common { get; set; }
        public List<Juso> juso { get; set; }
    }

    public class Root
    {
        public Results results { get; set; }
    }
    //devU01TX0FVVEgyMDIyMDUyMjE2NTUxNjExMjU5Nzg=
    public class KoreaAddressRequestParameter : IHttpRequestParameter
    {
        [Required] public int currentPage { get; set; } // 현재 페이지 번호
        [Required] public int countPerPage { get; set; } // 페이지당 출력 할 결과 Row 수
        [Required] public string keyword { get; set; } // 주소 검색어
        [Required] public string confmKey { get; set; } // 신청 시 발급받은 승인키
        public string resultType { get; set; }// 검색결과 형식 설정 (기본 XML 형식) json입력 시 Json 형식의 결과제공
        public string hstryYn { get; set; } // 2020년 12월 8일 추가된 항목 변동된 주소정보 포함 여부
        public string firstSort { get; set; } // 정확도정렬 none, 우선정렬 road
        public string addInfoYn { get; set; } // 2020년 12월 8일 후 추가된 출력결과 항목
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