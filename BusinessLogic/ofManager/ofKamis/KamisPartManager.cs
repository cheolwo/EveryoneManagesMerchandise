using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using System.Threading.Tasks;
using BusinessData.ofCommon.ofKamis.ofModel;
using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using System.Collections.Generic;
using System.Net.Http;
using BusinessData.ofCommon.ofKamis.ofRepository;
using System.Collections.Specialized;

namespace BusinessLoogic.ofManager.ofKamis
{
    public enum KamisWholeSaleRegion { 서울, 부산, 대구, 광주, 대전 }
    delegate void StimulatedFunc(char c);
    public class KamisConvertFactory
    {
        private Dictionary<int, StimulatedFunc> DicStimulatedFunc {get; set;}
        private StringBuilder RecognizingBuilder {get; set;}
        private Dictionary<string, string> KeyValuePairs {get; set;}
        private List<KamisPriceInfo> KamisPriceInfos {get; set;}
        public KamisConvertFactory()
        {
            DicStimulatedFunc = new();
            RecognizingBuilder = new();
        }
        public List<KamisPriceInfo> ToKamisPriceInfos(object[] items)
        {
            foreach(object item in items)
            {
                string itemStr = item.ToString();
                for(int i = 0; i <= itmeStr.Length; i++)
                {
                    bool Check = RecognizeCheck(itemStr[i]);
                    if(Check) {Recognize(itemStr[i]);}
                    else
                    {
                        int Stimulation = Math.Abs(RecognizingBuilder.ToString().GetHashCode());
                        DicStimulatedFunc[Stimulation](itemStr[i]);
                    }
                }
            }
        }
        // 대괄호가 끝나면 Key And Value로 나타낸 것을 개체화한다.
        private bool RecognizeCheck(char c)
        {
        }    
        private void Recognize(char c)
        {
            RecognizingBuilder.Append(c);
            string Rs = RecognizingBuilder.ToString();
            int Stimulation = Math.Abs(Rs.GetHashCode());
            DicStimulatedFunc[Stimulation](c);
        }
        // {
        private void StimulateFunc0(char c)
        {
            
        }
        // " ---> propName 즉 Key 구성
        private void StimulatedFunc1(char c) 
        {

        }
        // "" ---> Key 구성완료
        private void StimulatedFunc2(char c) 
        {

        }
        // "": ---> 아무것도 하지 않음
        private void StimulatedFunc3(char c) 
        {

        }
        // "":" ---> propValue 즉 Value 구성
        private void StimulatedFunc4(char c) 
        {

        }
        // "":"" ---> Value 구성완료
        private void StimulatedFunc5(char c) 
        {

        }
        // "":[ ---> Value를 Empty 로 초기화
        private void StimulatedFunc6(char c) 
        {

        }
        // "":[] ---> Value 구성완료
        private void StimulatedFunc7(char c) 
        {

        }
        // "":[], ---> 초기화
        private void StimulatedFunc8(char c) 
        {

        }

    }
    public class KamisAPIManager
    {
        public HttpClient _HttpClient { get; }
        private readonly KamisRequestFactory _kamisRequestFactory;
        private List<KamisPriceInfo> kamisPriceInfos = new();
        public ProductPriceResult ProductPriceResult = new();
        public KamisAPIManager(KamisRequestFactory kamisRequestFactory)
        {
            _HttpClient = new();
            _kamisRequestFactory = kamisRequestFactory;
        }
        // KamisAPiManager는 HttpRequestFactory 를 이용하여 Json으로 데이터를 받아오는 것 까지를 담당한다.
        // 이제 변환로직과 저장로직을 만들면 되겠다.
        public async Task CollectPriceInfoToDbByGetAPI(
                    string startdate, string enddate)
        {
            await _kamisRequestFactory.CreateRequestMessage(startdate, enddate);
            Dictionary<HttpRequestMessage, Dictionary<string, string>> DicWholeSaleHttpRequestMessage = _kamisRequestFactory.GetDictionaryWholeSalePriceHttpRequestMessage();
            Dictionary<HttpRequestMessage, Dictionary<string, string>> DicRetailHttpRequestMessage = _kamisRequestFactory.GetDictionaryRetailPriceHttpRequestMessage();
            var RequestMessages = DicWholeSaleHttpRequestMessage.Keys;
            foreach (var Message in RequestMessages)
            {
                HttpResponseMessage response = await _HttpClient.SendAsync(Message);
                using var responseStream = await response.Content.ReadAsStreamAsync();
                var Result = await System.Text.Json.JsonSerializer.DeserializeAsync<object>(responseStream);
                ProductPriceResult = JsonConvert.DeserializeObject<ProductPriceResult>(Result.ToString());
            }
        }
        public List<KamisPriceInfo> GetKamisPriceInfos()
        {
            return this.kamisPriceInfos;
        }
        private async Task CollectWholeSalePriceInfoByGetAPI(List<HttpRequestMessage> wholeSaleHttpRequests)
        {
            if (wholeSaleHttpRequests != null)
            {
                foreach (var httpRequest in wholeSaleHttpRequests)
                {
                    var Response = await _HttpClient.SendAsync(httpRequest);
                    using var responseStream = await Response.Content.ReadAsStreamAsync();
                    var Result = await System.Text.Json.JsonSerializer.DeserializeAsync<KamisPriceInfo>(responseStream);
                    kamisPriceInfos.Add(Result);
                }
            }
        }
        private async Task CollectRetailPriceInfoByGetAPI(List<HttpRequestMessage> retailHttpRequests)
        {
            if (retailHttpRequests != null)
            {
                foreach (var httpRequest in retailHttpRequests)
                {
                    var Response = await _HttpClient.SendAsync(httpRequest);
                    using var responseStream = await Response.Content.ReadAsStreamAsync();
                    var Result = await System.Text.Json.JsonSerializer.DeserializeAsync<KamisPriceInfo>(responseStream);
                    kamisPriceInfos.Add(Result);
                }
            }
        }
    }
    public class KamisRequestFactory
    {
        private Dictionary<HttpRequestMessage, Dictionary<string, string>> DictionaryWholeSalePriceHttpRequestMessage { get; set; }
        private Dictionary<HttpRequestMessage, Dictionary<string, string>> DictionaryRetailPriceHttpRequestMessage { get; set; }
        private const string BaseAddress = "http://www.kamis.or.kr/service/price";
        private const string APIUserId = "2281";
        private const string APIKey = "c8b4e1e9-273f-4fb4-8d5c-fdfcf7ae1533";
        private readonly KamisKindofCommodityRepository _KamisKindofCommodityRepository;
        private readonly KamisCountryAdministrationPartRepository _KamisCountryAdministrationPartRepository;
        public KamisRequestFactory(KamisKindofCommodityRepository kamisKindofCommodityRepository, 
                            KamisCountryAdministrationPartRepository kamisCountryAdministrationPartRepository)
        {
            _KamisCountryAdministrationPartRepository = kamisCountryAdministrationPartRepository;
            _KamisKindofCommodityRepository = kamisKindofCommodityRepository;
            DictionaryWholeSalePriceHttpRequestMessage = new();
            DictionaryRetailPriceHttpRequestMessage = new();
        }
        private List<KamisCountryAdministrationPart> DiviePartofWholeSaleRegion(List<KamisCountryAdministrationPart> coutries)
        {
            List<KamisCountryAdministrationPart> PartofWholeSaleRegion = new();
            foreach(var country in coutries)
            {
                if(country.Name.Equals(KamisWholeSaleRegion.서울.ToString())) { PartofWholeSaleRegion.Add(country);  continue; }
                if(country.Name.Equals(KamisWholeSaleRegion.부산.ToString())) { PartofWholeSaleRegion.Add(country); continue; }
                if (country.Name.Equals(KamisWholeSaleRegion.대전.ToString())) { PartofWholeSaleRegion.Add(country); continue; }
                if (country.Name.Equals(KamisWholeSaleRegion.대구.ToString())) { PartofWholeSaleRegion.Add(country); continue; }
                if (country.Name.Equals(KamisWholeSaleRegion.광주.ToString())) { PartofWholeSaleRegion.Add(country); continue; }
            }
            return PartofWholeSaleRegion;
        }     
        public Dictionary<HttpRequestMessage, Dictionary<string, string>> GetDictionaryWholeSalePriceHttpRequestMessage()
        {
            return DictionaryWholeSalePriceHttpRequestMessage;
        }
        public Dictionary<HttpRequestMessage, Dictionary<string, string>> GetDictionaryRetailPriceHttpRequestMessage()
        {
            return DictionaryRetailPriceHttpRequestMessage;
        }
        public async Task CreateRequestMessage(string startdate, string enddate)
        {
            var kindofCommodities = await _KamisKindofCommodityRepository.GetToListAsync();
            List<KamisCountryAdministrationPart> kamisCountryAdministrationParts = await _KamisCountryAdministrationPartRepository.GetToListAsync();
            foreach(var kindofCommodity in kindofCommodities)
            {
                List<NameValueCollection> BufferWholeSaleQueryStrings = PriceProductListStringBuilderByWholeSale(kindofCommodity, startdate, enddate);
                List<NameValueCollection> BufferRetailQueryStrings = PriceProductListStringBuilderByRetail(kindofCommodity, startdate, enddate);
                if(BufferWholeSaleQueryStrings.Count > 0)
                {
                    var countries = DiviePartofWholeSaleRegion(kamisCountryAdministrationParts);
                    foreach(var country in countries)
                    {
                         foreach(var WholeSaleQuetyString in BufferWholeSaleQueryStrings)
                         {
                            NameValueCollection FinalQuetyString = System.Web.HttpUtility.ParseQueryString(string.Empty);
                            FinalQuetyString.Add("p_countrycode", country.Id);
                            FinalQuetyString.Add("p_convert_kg_yn", "Y");
                            FinalQuetyString.Add("p_cert_key", APIKey);
                            FinalQuetyString.Add("p_cert_id", APIUserId);
                            FinalQuetyString.Add("p_returntype", "json");
                            string RequestQueryMessage = BaseAddress + "/"+WholeSaleQuetyString.ToString() +"&"+ FinalQuetyString.ToString();
                            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, RequestQueryMessage);
                            Dictionary<string, string> keyValuePairs = new();
                            keyValuePairs.Add(nameof(KamisKindofCommodity), WholeSaleQuetyString["p_kindcode"]);
                            keyValuePairs.Add(nameof(KamisCountryAdministrationPart), country.Id);
                            keyValuePairs.Add(nameof(KamisGrade), WholeSaleQuetyString["p_productrankcode"]);
                            DictionaryWholeSalePriceHttpRequestMessage.Add(httpRequestMessage, keyValuePairs);
                         }
                    }
                }
                if(BufferRetailQueryStrings.Count > 0)
                {
                    foreach(var country in kamisCountryAdministrationParts)
                    {
                        foreach(var RetailSaleQueryString in BufferRetailQueryStrings)
                        {
                            NameValueCollection FinalQuetyString = System.Web.HttpUtility.ParseQueryString(string.Empty);
                            FinalQuetyString.Add("p_countrycode", country.Id);
                            FinalQuetyString.Add("p_convert_kg_yn", "Y");
                            FinalQuetyString.Add("p_cert_key", APIKey);
                            FinalQuetyString.Add("p_cert_id", APIUserId);
                            FinalQuetyString.Add("p_returntype", "json");
                            string RequestQueryMessage = BaseAddress + "/" + RetailSaleQueryString.ToString() + "&" + FinalQuetyString.ToString();
                            HttpRequestMessage httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, RequestQueryMessage);
                            Dictionary<string, string> keyValuePairs = new();
                            keyValuePairs.Add(nameof(KamisKindofCommodity), RetailSaleQueryString["p_kindcode"]);
                            keyValuePairs.Add(nameof(KamisCountryAdministrationPart), country.Id);
                            keyValuePairs.Add(nameof(KamisGrade), RetailSaleQueryString["p_productrankcode"]);
                            DictionaryRetailPriceHttpRequestMessage.Add(httpRequestMessage, keyValuePairs);
                        }
                    }
                }
            }
        }
        private List<NameValueCollection> PriceProductListStringBuilderByWholeSale(KamisKindofCommodity kindofCommodity, string startdate, string enddate)
        {
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            queryString.Add("xml.do?action", "periodProductList");
            queryString.Add("p_productclscode", "02");
            queryString.Add("p_startday", startdate);
            queryString.Add("p_endday", enddate);
            queryString.Add("p_itemcategorycode", kindofCommodity.KamisPartId);
            queryString.Add("p_itemcode", kindofCommodity.KamisCommodityId);
            queryString.Add("p_kindcode", kindofCommodity.Code);

            return WholeSalePriceProductListStringBuilderByGrade(queryString, kindofCommodity);
        }
        private List<NameValueCollection> PriceProductListStringBuilderByRetail(KamisKindofCommodity kindofCommodity, string startdate, string enddate)
        {
            NameValueCollection queryString = System.Web.HttpUtility.ParseQueryString(string.Empty);
            queryString.Add("xml.do?action", "periodProductList");
            queryString.Add("p_productclscode", "01");
            queryString.Add("p_startday", startdate);
            queryString.Add("p_endday", enddate);
            queryString.Add("p_itemcategorycode", kindofCommodity.KamisPartId);
            queryString.Add("p_itemcode", kindofCommodity.KamisCommodityId);
            queryString.Add("p_kindcode", kindofCommodity.Code);
            return RetailPriceProductListStringBuilderByGrade(queryString, kindofCommodity);
        }
        private List<NameValueCollection> WholeSalePriceProductListStringBuilderByGrade(NameValueCollection ByWholeSale, KamisKindofCommodity kamisKindofCommodity)
        {
            var Grades = kamisKindofCommodity.WholeSaleGrade.Split(',');
            List<NameValueCollection> BufferQueryString = new();
            if (Grades.Length > 0)
            {          
                foreach(string grade in Grades)
                {
                    NameValueCollection nameValueCollection = System.Web.HttpUtility.ParseQueryString(string.Empty);
                    foreach (string key in ByWholeSale)
                    {                     
                        nameValueCollection.Add(key, ByWholeSale[key]);
                    }
                    nameValueCollection.Add("p_productrankcode", grade);
                    BufferQueryString.Add(nameValueCollection);
                }
            }
            return BufferQueryString;
        }
        private List<NameValueCollection> RetailPriceProductListStringBuilderByGrade(NameValueCollection ByRetail, KamisKindofCommodity kamisKindofCommodity)
        {
            var Grades = kamisKindofCommodity.RetailSaleGrade.Split(',');
            List<NameValueCollection> BufferQueryString = new();
            if (Grades.Length > 0)
            {
                foreach (var grade in Grades)
                {
                    NameValueCollection nameValueCollection = System.Web.HttpUtility.ParseQueryString(string.Empty);
                    foreach (string key in ByRetail)
                    {
                        nameValueCollection.Add(key, ByRetail[key]);
                    }
                    nameValueCollection.Add("p_productrankcode", grade);
                    BufferQueryString.Add(nameValueCollection);
                }
            }
            return BufferQueryString;
        }
    }
    public class KamisPartManager : EntityManager<KamisPart>
    {
        public KamisPartManager(IEntityDataRepository<KamisPart> EntityDataRepository, 
            IEntityIdFactory<KamisPart> EntityIdFactory,
            IEntityFileFactory<KamisPart> entityFileFactory, 
            IEntityBlobStorage<KamisPart> entityBlobStorage, 
            DicConvertFactory<KamisPart> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisPart> CreateAsync(KamisPart entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
    public class KamisGradeManager : EntityManager<KamisGrade>
    {
        public KamisGradeManager(IEntityDataRepository<KamisGrade> EntityDataRepository,
            IEntityIdFactory<KamisGrade> EntityIdFactory,
            IEntityFileFactory<KamisGrade> entityFileFactory,
            IEntityBlobStorage<KamisGrade> entityBlobStorage,
            DicConvertFactory<KamisGrade> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisGrade> CreateAsync(KamisGrade entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
    public class KamisCommodityManager : EntityManager<KamisCommodity>
    {
        public KamisCommodityManager(IEntityDataRepository<KamisCommodity> EntityDataRepository, 
            IEntityIdFactory<KamisCommodity> EntityIdFactory,
            IEntityFileFactory<KamisCommodity> entityFileFactory, 
            IEntityBlobStorage<KamisCommodity> entityBlobStorage, 
            DicConvertFactory<KamisCommodity> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisCommodity> CreateAsync(KamisCommodity entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
    public class KamisKindofCommodityManager : EntityManager<KamisKindofCommodity>
    {
        public KamisKindofCommodityManager(IEntityDataRepository<KamisKindofCommodity> EntityDataRepository, 
            IEntityIdFactory<KamisKindofCommodity> EntityIdFactory,
            IEntityFileFactory<KamisKindofCommodity> entityFileFactory, 
            IEntityBlobStorage<KamisKindofCommodity> entityBlobStorage, 
            DicConvertFactory<KamisKindofCommodity> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisKindofCommodity> CreateAsync(KamisKindofCommodity entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
    public class KamisCountryAdministrationPartManager : EntityManager<KamisCountryAdministrationPart>
    {
        public KamisCountryAdministrationPartManager(IEntityDataRepository<KamisCountryAdministrationPart> EntityDataRepository, 
            IEntityIdFactory<KamisCountryAdministrationPart> EntityIdFactory,
            IEntityFileFactory<KamisCountryAdministrationPart> entityFileFactory, 
            IEntityBlobStorage<KamisCountryAdministrationPart> entityBlobStorage, 
            DicConvertFactory<KamisCountryAdministrationPart> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisCountryAdministrationPart> CreateAsync(KamisCountryAdministrationPart entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
    public class KamisMarketManager : EntityManager<KamisMarket>
    {
        public KamisMarketManager(IEntityDataRepository<KamisMarket> EntityDataRepository, 
            IEntityIdFactory<KamisMarket> EntityIdFactory,
            IEntityFileFactory<KamisMarket> entityFileFactory, 
            IEntityBlobStorage<KamisMarket> entityBlobStorage, 
            DicConvertFactory<KamisMarket> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisMarket> CreateAsync(KamisMarket entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
    public class KamisWholeSalePriceManager : EntityManager<KamisWholeSalePrice>
    {
        public KamisWholeSalePriceManager(IEntityDataRepository<KamisWholeSalePrice> EntityDataRepository, 
            IEntityIdFactory<KamisWholeSalePrice> EntityIdFactory,
            IEntityFileFactory<KamisWholeSalePrice> entityFileFactory, 
            IEntityBlobStorage<KamisWholeSalePrice> entityBlobStorage, 
            DicConvertFactory<KamisWholeSalePrice> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisWholeSalePrice> CreateAsync(KamisWholeSalePrice entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
    public class KamisRetailPriceManager : EntityManager<KamisRetailPrice>
    {
        public KamisRetailPriceManager(IEntityDataRepository<KamisRetailPrice> EntityDataRepository, 
            IEntityIdFactory<KamisRetailPrice> EntityIdFactory,
            IEntityFileFactory<KamisRetailPrice> entityFileFactory, 
            IEntityBlobStorage<KamisRetailPrice> entityBlobStorage, 
            DicConvertFactory<KamisRetailPrice> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisRetailPrice> CreateAsync(KamisRetailPrice entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
}