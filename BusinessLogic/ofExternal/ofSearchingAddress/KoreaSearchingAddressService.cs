using System.Reflection;
using System;
using BusinessLogic.ofExternal.ofCommon;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

namespace BusinessLogic.ofExternal.ofSearchingService
{
    public enum ErrorCodeKoreaSearchingAddressService
    {
        E0001, E0002, E0003, E0004, E0005, E0006, E0007, E0008, E0009, E0010, E0011, E0012, E0013, E0014, E0015
    }
    public class KoreaSearchingAddressService
    {
        public HttpClient _httpClient { get; set; }
        public KoreaSearchingAddressService()
        {
            _httpClient = new();
            _httpClient.BaseAddress = new Uri("https://www.juso.go.kr");
        }
        public async Task<HttpResponseMessage> SearchAddress(string Address)
        {
            KoreaAddressRequestParameter KoreaAddressRequestParameter = new(Address);
            string requestUri = "/addrlink/addrLinkApiJsonp.do";
            string getUri = HttpClientExtensions.GetUri(requestUri, KoreaAddressRequestParameter);
            return await _httpClient.GetAsync(getUri);
        }
        public async Task<List<string>> GetKoreadAddressByKeyword(string Address)
        {
            KoreaAddressRequestParameter KoreaAddressRequestParameter = new(Address);
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
                listAddress.Add(addr.roadAddr);
            }
            return listAddress;
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
        public string errorMessage { get; set; }
        public string countPerPage { get; set; }
        public string totalCount { get; set; }
        public string errorCode { get; set; }
        public string currentPage { get; set; }
    }

    public class Juso
    {
        public string detBdNmList { get; set; }
        public string engAddr { get; set; }
        public string rn { get; set; }
        public string emdNm { get; set; }
        public string zipNo { get; set; }
        public string roadAddrPart2 { get; set; }
        public string emdNo { get; set; }
        public string sggNm { get; set; }
        public string jibunAddr { get; set; }
        public string siNm { get; set; }
        public string roadAddrPart1 { get; set; }
        public string bdNm { get; set; }
        public string admCd { get; set; }
        public string udrtYn { get; set; }
        public string lnbrMnnm { get; set; }
        public string roadAddr { get; set; }
        public string lnbrSlno { get; set; }
        public string buldMnnm { get; set; }
        public string bdKdcd { get; set; }
        public string liNm { get; set; }
        public string rnMgtSn { get; set; }
        public string mtYn { get; set; }
        public string bdMgtSn { get; set; }
        public string buldSlno { get; set; }
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