using System.Collections;
using System.Reflection;
using System;
using BusinessLogic.ofExternal.ofCommon;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net.Http;
using System.Diagnostics;

namespace BusinessLogic.ofExternal.ofSearchingService
{
    public enum ErrorCodeKoreaSearchingAddressService
    {
        E0001, E0002, E0003, E0004, E0005, E0006, E0007, E0008, E0009, E0010, E0011, E0012, E0013, E0014, E0015
    }
    public class KoreaSearchingAddressService
    {
        private const string apiKey = "";
        public HttpClient _httpClient {get; set;}
        public KoreaSearchingAddressService()
        {
            _httpClient = new();
            _httpClient.BaseAddress = new Uri("https://www.juso.go.kr");
        }
        public async Task<KoreadAddressExternalDTO> SearchAddress(string Address)
        {
            KoreaAddressRequestParameter KoreaAddressRequestParameter = new(Address);
            string requestUri = "";
            string getUri = HttpClientExtensions.GetUriByRequired<KoreaAddressRequestParameter>(requestUri, KoreaAddressRequestParameter);
            return await _httpClient.GetFromJsonAsync<KoreadAddressExternalDTO>(getUri);
        }
    }
    public class KoreadAddressExternalDTO
    {
        public common common {get;set;}
        public List<juso> jusos {get; set;}
        private class common
        {
            public string totalCount {get; set;} // 총 검색 데이터 수
            public int currentPage {get; set;} // 페이지 번호
            public int countPerPage {get; set;} // 페이지 당 출력할 결과 Row 수
            public string errorCode {get; set;} // 에러코드
            public string errorMessage {get; set;} // 에러 메시지
        }
        private class juso
        {
            public string roadAddr {get; set;} // 전체 도로명 주소
            public string roadAddrPart1 {get; set;} // 도로명 주소
            public string roadAddrPart2 {get; set;} // 도로명 주소 참고항목
            public string jibunAddr {get; set;} // 지번 ㅈ어보
            public string engAddr {get; set;} // 도로명 주소(영문)
            public string zipNo {get; set;} // 우편번호
            public string admCd {get; set;} // 행정구역코드
            public string rnMgtSn {get; set;} //도로명코드
            public string bdMgtSn {get; set;} //건물관리번호
            public string detBdNmList {get; set;} //상세건물명
            public string bdNm {get; set;} //건물명
            public string bdKdcd {get; set;} // 공동주택여부 (1 : 공동주택 0 : 비공동주택)
            public string siNm {get; set;} //시도명
            public string sggNm {get; set;} //시군구명
            public string emdNm {get; set;} //읍면동명
            public string liNm {get; set;} //법정리명
            public string Rn {get; set;} //도로명
            public string udrtYn {get; set;} //지하여부
            public string buldMnnm {get; set;} //건물본번
            public string buldSlno {get; set;} // 건물부번
            public string mtYn {get; set;} //산여부
            public int lnbrMnnm {get; set;} //지번본지
            public int lnbrSlno {get; set;} //지번부호
            public string emdNo {get; set;} //읍면동일련번호
            public string hstryYn {get; set;} //추가된 항목 : 변동이력여부
            public string relJibun {get; set;} //추가된 항목 : 관련지번
            public string hemdNm {get; set;} //추가된 항목 : 관할주민센터
        }
    }
    
    public class KoreaAddressRequestParameter : IHttpRequestParameter
    {
        [Required]public string confmKey {get; set;} // 신청 시 발급받은 승인키
        [Required]public int currentPage {get; set;} // 현재 페이지 번호
        [Required]public int countPerPage {get; set;} // 페이지당 출력 할 결과 Row 수
        [Required]public string keyword {get; set;} // 주소 검색어
        public string resultType {get; set;} // 검색결과 형식 설정 (기본 XML 형식) json입력 시 Json 형식의 결과제공
        public string hstryYn {get; set;} // 2020년 12월 8일 추가된 항목 변동된 주소정보 포함 여부
        public string firstSort {get; set;} // 정확도정렬 none, 우선정렬 road
        public string addInfoYn {get; set;} // 2020년 12월 8일 후 추가된 출력결과 항목
        public KoreaAddressRequestParameter(string keyword)
        {
            this.keyword = keyword;
            currentPage = 1;
            countPerPage = 10;
            resultType = "json";
            // etc....
        }
        public IEnumerable<PropertyInfo> GetRequiredProps()
        {
            var props = typeof(KoreaAddressRequestParameter).GetProperties();
            List<PropertyInfo> propertyInfos = new();
            foreach(var prop in props)
            {
                var Required = prop.GetCustomAttribute<RequiredAttribute>();
                if(Required is not null)
                {
                    propertyInfos.Add(prop);
                }
            }
            return propertyInfos;
        }
    }
}