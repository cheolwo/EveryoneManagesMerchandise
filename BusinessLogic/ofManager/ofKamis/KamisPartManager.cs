using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using System.Threading.Tasks;
using System;
using BusinessData.ofCommon.ofKamis.ofModel;
using BusinessData;
using BusinessData.ofGeneric.ofIdFactory;
using System.Net.Http;
using System.Web;

namespace BusinessLoogic.ofManager.ofKamis
{
    public class KamisAPIManager
    {
        // ResponseField 
        /*
         *  //itemname :  품목명
         *  //kindname : 품종명
         *  // countryname : 시군구
         *  //marketname :  마켓명
         *  // yyyy : 연도
         *  // regday : 날짜
         *  // price : 가격
         */
        /*
         * http://www.kamis.or.kr/service/price/xml.do?action=periodProductList&p_productclscode=02&p_startday=2015-10-01&p_endday=2015-12-01&p_itemcategorycode=200&p_itemcode=212&p_kindcode=00&p_productrankcode=04&p_countrycode=1101&p_convert_kg_yn=Y&p_cert_key=111&p_cert_id=222&p_returntype=xm
         */
        private HttpClient HttpClient = new();
        private readonly string CertKey = "	c8b4e1e9-273f-4fb4-8d5c-fdfcf7ae1533";
        private readonly string CertId = "2281";
        public KamisAPIManager()
        //c8b4e1e9-273f-4fb4-8d5c-fdfcf7ae1533
        {
            HttpClient.BaseAddress  = new Uri("http://www.kamis.or.kr/service/price");
        }
        public async Task<HttpResponseMessage> GetPrice()
        {
            var uriBuilder = new UriBuilder(HttpClient.BaseAddress);
            //var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            //query["p_productclscode"] = "02";
            //query["p_startday"] = "2021-06-01";
            //query["p_endday"] = "2021-07-01";
            //query["p_itemcategorycode"] = "200";
            //query["p_itemcode"] = "212";
            //query["p_kindcode"] = "00";
            //query["p_productrankcode"] = "04";
            //query["p_countrycode"] = "1101";
            //query["p_convert_kg_yn"] = "Y";
            //query["p_cert_key"] = CertKey;
            //query["p_cert_id"] = CertId;
            //query["p_returntype"] = "xml";
           return await HttpClient.GetAsync("/xml.do?action=periodProductList" +
               "&p_productclscode=02" +
               "&p_startday=2021-12-01" +
               "&p_endday=2021-12-30" +
               "&p_itemcategorycode=200" +
               "&p_itemcode=212" +
               "&p_kindcode=00" +
               "&p_productrankcode=04" +
               "&p_countrycode=1101" +
               "&p_convert_kg_yn=Y" +
               "&p_cert_key=c8b4e1e9-273f-4fb4-8d5c-fdfcf7ae1533&p_cert_id=2281" +
               "&p_returntype=xml");

            //HttpClient.BaseAddress = uriBuilder.ToString();
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