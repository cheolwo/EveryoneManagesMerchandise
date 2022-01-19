using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using System.Threading.Tasks;
using BusinessData.ofCommon.ofKamis.ofModel;
using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using System.Net.Http;
using BusinessData.ofCommon.ofKamis.ofRepository;

namespace BusinessLoogic.ofManager.ofKamis
{
    public enum KamisWholeSaleRegion { 서울, 부산, 대구, 광주, 대전 }
    public class KamisRequestFactory
    {
        private Dictionary<HttpRequestMessage, Dictionary<string, string>> DictionaryWholeSalePriceHttpRequestMessage { get; set; }
        private Dictionary<HttpRequestMessage, Dictionary<string, string>> DictionaryRetailPriceHttpRequestMessage { get; set; }
        private Dictionary<string, string> keyValuePairs { get; set; }
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
            keyValuePairs = new Dictionary<string, string>();
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
        private static Dictionary<string, string> CopyToDic(Dictionary<string, string> keyValuePairs)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            foreach(var key in keyValuePairs.Keys)
            {
                dic.Add(key, keyValuePairs[key]);
            }
            return dic;
        }
        public async Task CreateRequestMessage(string startdate, string enddate)
        {
            var kindofCommodities = await _KamisKindofCommodityRepository.GetToListAsync();
            List<KamisCountryAdministrationPart> kamisCountryAdministrationParts = await _KamisCountryAdministrationPartRepository.GetToListAsync();
            foreach(var kindofCommodity in kindofCommodities)
            {
                Debug.WriteLine("CreateRequestMessage");
                List<NameValueCollection> BufferWholeSaleQueryStrings = PriceProductListStringBuilderByWholeSale(kindofCommodity, startdate, enddate);
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
                            keyValuePairs.Add(nameof(KamisCountryAdministrationPart), country.Id);
                            keyValuePairs.Add(nameof(KamisGrade), WholeSaleQuetyString["p_productrankcode"]);
                            var dic = CopyToDic(keyValuePairs);
                            keyValuePairs.Remove(nameof(KamisCountryAdministrationPart));
                            keyValuePairs.Remove(nameof(KamisGrade));
                            DictionaryWholeSalePriceHttpRequestMessage.Add(httpRequestMessage, dic);
                         }
                    }
                    keyValuePairs.Clear();
                }
                List<NameValueCollection> BufferRetailQueryStrings = PriceProductListStringBuilderByRetail(kindofCommodity, startdate, enddate);
                if (BufferRetailQueryStrings.Count > 0)
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
                            keyValuePairs.Add(nameof(KamisCountryAdministrationPart), country.Id);
                            keyValuePairs.Add(nameof(KamisGrade), RetailSaleQueryString["p_productrankcode"]);
                            var dic = CopyToDic(keyValuePairs);
                            keyValuePairs.Remove(nameof(KamisCountryAdministrationPart));
                            keyValuePairs.Remove(nameof(KamisGrade));
                            DictionaryRetailPriceHttpRequestMessage.Add(httpRequestMessage, dic);
                        }
                    }
                    keyValuePairs.Clear();
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
            keyValuePairs.Add(nameof(KamisKindofCommodity), kindofCommodity.Id);
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
            keyValuePairs.Add(nameof(KamisKindofCommodity), kindofCommodity.Id);
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
            return await base.CreateAsync(entity);
        }
        public async Task<KamisMarket> GetByMarketName(string marektName)
        {
            return await _EntityDataRepository.GetByNameAsync(marektName);
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
            return await base.CreateAsync(entity);
        }
        public async Task<KamisWholeSalePrice> FirstOrDefaultAsync()
        {
            return await _EntityDataRepository.FirstOrDefaultAsync();
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
            return await base.CreateAsync(entity);
        }
    }
}