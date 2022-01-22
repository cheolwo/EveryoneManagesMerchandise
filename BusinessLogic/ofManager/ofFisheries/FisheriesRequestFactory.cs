using BusinessData;
using BusinessData.ofCommon.ofFisheries.ofModel;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Net.Http;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofFisheries
{
    // 추상적으로 모듈화 해놓으니까 개편하네.
    // 각 센터의 품목별로 RequestFactory를 만들어야돼.
    // 그렇기에 굳이 여러 Repository 모듈을 DI 할 필요가 없어.

    /* 창고정보 API URL 예시
    // page랑 rows는 WebAPI로 넘겨줄 떄 이용되는 Query
    http://apis.data.go.kr/1192000
    /select0120List/
    getselect0120List?serviceKey=인증키(URL Encode)
    & pageNo=1
    &numOfRows=10
    &mxtrNm=경인북부수산업협동조합
    &wrhousNm=판매사업과(이용)
    */
    /* 재고정보 API URL 예시
    http://apis.data.go.kr/1192000
    /select0150List/
    getselect0150List?serviceKey=인증키(URL Encode)
    & pageNo=1&numOfRows=10
    &baseDt=20210101
    &mxtrNm=경인북부수산업협동조합
    &wrhousNm=판매사업과(이용)
    &mprcStdCodeNm=고등어
    */
    /* 입출고정보 API URL 예시
http://apis.data.go.kr/1192000
/select0140List/
getselect0140List?serviceKey=인증키(URL Encode)
& pageNo=1
&numOfRows=10
&baseDt=20210101
&mxtrNm=인천수산업협동조합
&wrhousNm=이용가공팀(이용)
&mprcStdCodeNm=기타가오리류
&inOutNm=입고
*/

    public class FisheriesRequestFactory
    {
        private const string BaseAddress = "http://apis.data.go.kr/1192000";
        // 창고정보 API Key
        private const string CenterAPIKey = "MES0OhKUsU568JFM%2BqISI3PAtswnNtc9o8YqvKx7MKy1qo%2Fm7guBFt6vsaf79nfAJxnbwt8LMuEklkK7SfB30A%3D%3D";
        // 재고정보 API Key
        private const string MCommodityAPIKey = "MES0OhKUsU568JFM%2BqISI3PAtswnNtc9o8YqvKx7MKy1qo%2Fm7guBFt6vsaf79nfAJxnbwt8LMuEklkK7SfB30A%3D%3D";
        // 입출고정보 API Key
        private const string SECommodityAPIKey = "MES0OhKUsU568JFM%2BqISI3PAtswnNtc9o8YqvKx7MKy1qo%2Fm7guBFt6vsaf79nfAJxnbwt8LMuEklkK7SfB30A%3D%3D";
        private readonly ICenterDataRepository<Fisheries> _CenterDataRepository;
        private readonly IEntityDataRepository<Copartnership> _entityDataRepostiroy;
        public FisheriesRequestFactory(ICenterDataRepository<Fisheries> centerDataRepository, IEntityDataRepository<Copartnership> entityDataRepostiroy)
        {
            _CenterDataRepository = centerDataRepository;
            _entityDataRepostiroy = entityDataRepostiroy;
        }
        private string BaseFisheriesAPIMessage(string pageNo, string NumofRow,
            string mxtrNm, string WarehouseName)
        {
            NameValueCollection nameValueCollection = System.Web.HttpUtility.ParseQueryString(string.Empty);
            nameValueCollection.Add("serviceKey", CenterAPIKey);
            nameValueCollection.Add("pageNo", pageNo);
            nameValueCollection.Add("numOfRows", NumofRow);
            nameValueCollection.Add("mxtrNm", mxtrNm);
            nameValueCollection.Add("wrhousNm", WarehouseName);
            string Query = nameValueCollection.ToString();
            return BaseAddress + $"/select0120List/getselect0120List?" + Query;
        }
        private string BaseMCommodityAPIMessage(string pageNo, string NumofRow, string BaseDt,
            string mxtrNm, string WarehouseName, string mprcStdCodeNm)
        {
            NameValueCollection nameValueCollection = System.Web.HttpUtility.ParseQueryString(string.Empty);
            nameValueCollection.Add("serviceKey", MCommodityAPIKey);
            nameValueCollection.Add("pageNo", pageNo);
            nameValueCollection.Add("numOfRows", NumofRow);
            nameValueCollection.Add("baseDt", BaseDt);
            nameValueCollection.Add("mxtrNm", mxtrNm);
            nameValueCollection.Add("wrhousNm", WarehouseName);
            nameValueCollection.Add("mprcStdCodeNm", mprcStdCodeNm);
            string Query = nameValueCollection.ToString();
            return BaseAddress + $"/select0120List/getselect0120List?" + Query;
        }
        private string BaseSECommodityAPIMessage(string pageNo, string NumofRow, string BaseDt,
            string mxtrNm, string WarehouseName, string mprcStdCodeNm, string inOutNM)
        {
            NameValueCollection nameValueCollection = System.Web.HttpUtility.ParseQueryString(string.Empty);
            nameValueCollection.Add("serviceKey", SECommodityAPIKey);
            nameValueCollection.Add("pageNo", pageNo);
            nameValueCollection.Add("numOfRows", NumofRow);
            nameValueCollection.Add("baseDt", BaseDt);
            nameValueCollection.Add("mxtrNm", mxtrNm);
            nameValueCollection.Add("wrhousNm", WarehouseName);
            nameValueCollection.Add("mprcStdCodeNm", mprcStdCodeNm);
            nameValueCollection.Add("inOutNm", inOutNM);
            string Query = nameValueCollection.ToString();
            return BaseAddress + $"/select0120List/getselect0120List?" + Query;
        }
        // 조합명, 창고명, 품목명, 입출고구분, 기준일자
        public async Task<List<HttpRequestMessage>> MakeFisheriesRequestMessage()
        {
            var Fisheries = await _CenterDataRepository.GetToListAsync();
            List<HttpRequestMessage> httpRequestMessages = new();
            foreach (var center in Fisheries)
            {
                Copartnership copartnership = await _entityDataRepostiroy.GetByIdAsync(center.CopartnershipId);
                string RequestMessage = BaseFisheriesAPIMessage("1", "10", copartnership.Name, center.Name);
                httpRequestMessages.Add(new HttpRequestMessage(HttpMethod.Get, RequestMessage));
            }
            return httpRequestMessages;
        }
        public async Task<List<HttpRequestMessage>> MakeMFishCommodityRequestMessage(string dt)
        {
            var Fisheries = await _CenterDataRepository.GetToListWithCommodities();
            List<HttpRequestMessage> httpRequestMessages = new();
            foreach (var center in Fisheries)
            {
                Copartnership copartnership = await _entityDataRepostiroy.GetByIdAsync(center.CopartnershipId);
                foreach (var commodity in center.Commodities)
                {
                    string RequestMessage = BaseMCommodityAPIMessage("1", "10", dt, copartnership.Name,
                        center.Name, commodity.Name);
                    httpRequestMessages.Add(new HttpRequestMessage(HttpMethod.Get, RequestMessage));
                }
            }
            return httpRequestMessages;
        }
        public async Task<List<HttpRequestMessage>> MakeSEFishCommodityRequestMessage(string dt, bool IsIn)
        {
            if (IsIn)
            {
                var Fisheries = await _CenterDataRepository.GetToListWithSStatuses();
                List<HttpRequestMessage> httpRequestMessages = new();
                foreach (var center in Fisheries)
                {
                    Copartnership copartnership = await _entityDataRepostiroy.GetByIdAsync(center.CopartnershipId);
                    foreach (var commodity in center.Commodities)
                    {                      
                        string RequestMessage = BaseSECommodityAPIMessage("1", "10", dt, copartnership.Name,
                            center.Name, commodity.Name, "입고");
                        httpRequestMessages.Add(new HttpRequestMessage(HttpMethod.Get, RequestMessage));
                    }
                }
                return httpRequestMessages;
            }
            else
            {
                var Fisheries = await _CenterDataRepository.GetToListWithEStatuses();
                List<HttpRequestMessage> httpRequestMessages = new();
                foreach (var center in Fisheries)
                {
                    Copartnership copartnership = await _entityDataRepostiroy.GetByIdAsync(center.CopartnershipId);
                    foreach (var commodity in center.Commodities)
                    {                    
                        string RequestMessage = BaseSECommodityAPIMessage("1", "10", dt, copartnership.Name,
                            center.Name, commodity.Name, "출고");
                        httpRequestMessages.Add(new HttpRequestMessage(HttpMethod.Get, RequestMessage));
                    }
                }
                return httpRequestMessages;
            }
        }
    }
}