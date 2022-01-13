using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using System.Threading.Tasks;
using System;
using BusinessData.ofCommon.ofKamis.ofModel;
using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;

namespace BusinessLoogic.ofManager.ofKamis
{
    public class KamisAPIManager
    {
        public HttpClient _HttpClient {get;}
        public KamisAPIManager()
        {
            _HttpClient = new();
        }
    }
    public class KamisRequestFactory
    {
        private List<string> RequestBufferUriFactory {get; set;}
        private List<string> RequestUriFactory {get; set;}
        private List<string> BufferWholeSaleUries {get; set;}
        private List<string> BufferRetailUries {get; set;}
        private const string BaseAddress = "http://www.kamis.or.kr/service/price";
        public KamisRequestFactory()
        {   
            RequestBufferUriFactory = new();
            RequestUriFactory = new();
        }
        public List<string> Create(string startdate, string enddate, List<KamisKindofCommodity> commodities,
                                List<KamisCountryAdministrationPart> kamiscountryAdministrationparts)
        {
            foreach(var commodity in commodities)
            {
                var gradeSplited = commodity.grade.Split(',');
                foreach(var grade in gradeSplited)
                {
                    string BufWholeslaeUri = PriceProductListStringFactory(commodity, grade, true, startdate, enddate);
                    BufferWholeSaleUries.Add(BufUri);
                    string BufRetailUri = PriceProductListStringFactory(commodity, grade, false, startdate, enddate);
                    BufferRetailUries.Add(BufRetailUri);
                }
            }
            // 지역코드를 전달하는 것부터 집에서 시작.
        }
        
        /*
            "http://www.kamis.or.kr/service/price/xml.do?action=periodProductList" +
            "&p_productclscode=02&p_startday=2020-10-01&p_endday=2020-12-01" +
            "&p_itemcategorycode=200&p_itemcode=212&p_kindcode=00&p_productrankcode=04&p_countrycode=1101&p_convert_kg_yn=Y" +
            "&p_cert_key=c8b4e1e9-273f-4fb4-8d5c-fdfcf7ae1533&p_cert_id=2281&p_returntype=json");
        */
        public static string PriceProductListStringFactory(KindofCommodity kindofCommodity, string grade, bool wholesale,
                                                string startdate, string enddate)
        {
            string p_productclscode;
            if(wholesale)
            {
                p_productclscode = "02"; //도매
                return $"{BaseAddress}/xml.do?action=periodProductList"+
                $"&p_productclscode={p_productclscode}"+
                $"&p_startday={startdate}"+
                $"&p_endday={enddate}"+
                $"&p_itemcategorycode={kindofCommodity.KamisParyId}"+
                $"&p_itemcode={kindofCommodity.KamisCommodityId}"+
                $"&p_kindcode={knidofCommodity.Code}"+
                $"&p_productrankcode={grade}";
            }
            else
            {
                p_productclscode = "01"; //소매
                return $"{BaseAddress}/xml.do?action=periodProductList"+
                $"&p_productclscode={p_productclscode}"+
                $"&p_startday={startdate}"+
                $"&p_endday={enddate}"+
                $"&p_itemcategorycode={kindofCommodity.KamisParyId}"+
                $"&p_itemcode={kindofCommodity.KamisCommodityId}"+
                $"&p_kindcode={knidofCommodity.Code}"+
                $"&p_productrankcode={grade}";
            }
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
    public class KamisSubCountryAdministrationPartManager : EntityManager<KamisSubCountryAdministrationPart>
    {
        public KamisSubCountryAdministrationPartManager(IEntityDataRepository<KamisSubCountryAdministrationPart> EntityDataRepository, 
            IEntityIdFactory<KamisSubCountryAdministrationPart> EntityIdFactory,
            IEntityFileFactory<KamisSubCountryAdministrationPart> entityFileFactory, 
            IEntityBlobStorage<KamisSubCountryAdministrationPart> entityBlobStorage, 
            DicConvertFactory<KamisSubCountryAdministrationPart> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisSubCountryAdministrationPart> CreateAsync(KamisSubCountryAdministrationPart entity)
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
    public class KamisDayPriceManager : EntityManager<KamisDayPrice>
    {
        public KamisDayPriceManager(IEntityDataRepository<KamisDayPrice> EntityDataRepository, 
            IEntityIdFactory<KamisDayPrice> EntityIdFactory,
            IEntityFileFactory<KamisDayPrice> entityFileFactory, 
            IEntityBlobStorage<KamisDayPrice> entityBlobStorage, 
            DicConvertFactory<KamisDayPrice> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KamisDayPrice> CreateAsync(KamisDayPrice entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
}