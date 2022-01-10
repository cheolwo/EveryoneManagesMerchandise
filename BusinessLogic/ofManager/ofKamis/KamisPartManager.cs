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