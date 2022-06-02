using BusinessData.ofDataAccessLayer.ofCommon.ofHsCode;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofExternalManager.ofHsCode
{
    public class PracticalHsCodeManager : EntityManager<PracticalHsCode>
    {
        public PracticalHsCodeManager(IEntityDataRepository<PracticalHsCode> EntityDataRepository, 
            IEntityIdFactory<PracticalHsCode> EntityIdFactory,
            IEntityFileFactory<PracticalHsCode> entityFileFactory, 
            IEntityBlobStorage<PracticalHsCode> entityBlobStorage, 
            DicConvertFactory<PracticalHsCode> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<PracticalHsCode> CreateAsync(PracticalHsCode entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
    public class SubPracticalHsCodeManager : EntityManager<SubPracticalHsCode>
    {
        public SubPracticalHsCodeManager(IEntityDataRepository<SubPracticalHsCode> EntityDataRepository,
            IEntityIdFactory<SubPracticalHsCode> EntityIdFactory,
            IEntityFileFactory<SubPracticalHsCode> entityFileFactory,
            IEntityBlobStorage<SubPracticalHsCode> entityBlobStorage,
            DicConvertFactory<SubPracticalHsCode> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<SubPracticalHsCode> CreateAsync(SubPracticalHsCode entity)
        {
            return await base.CreateAsync(entity);
        }
    }
    public class DetailPracticalHsCodeManager : EntityManager<DetailPracticalHsCode>
    {
        public DetailPracticalHsCodeManager(IEntityDataRepository<DetailPracticalHsCode> EntityDataRepository,
            IEntityIdFactory<DetailPracticalHsCode> EntityIdFactory,
            IEntityFileFactory<DetailPracticalHsCode> entityFileFactory,
            IEntityBlobStorage<DetailPracticalHsCode> entityBlobStorage,
            DicConvertFactory<DetailPracticalHsCode> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<DetailPracticalHsCode> CreateAsync(DetailPracticalHsCode entity)
        {
            return await base.CreateAsync(entity);          
        }
    }
    public class HsCodePartManager : EntityManager<HsCodePart>
    {
        public HsCodePartManager(IEntityDataRepository<HsCodePart> EntityDataRepository,
            IEntityIdFactory<HsCodePart> EntityIdFactory,
            IEntityFileFactory<HsCodePart> entityFileFactory,
            IEntityBlobStorage<HsCodePart> entityBlobStorage,
            DicConvertFactory<HsCodePart> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<HsCodePart> CreateAsync(HsCodePart entity)
        {
            return await base.CreateAsync(entity);
        }
    }
    public class SubPartofHsCodeManager : EntityManager<SubPartofHsCode>
    {
        public SubPartofHsCodeManager(IEntityDataRepository<SubPartofHsCode> EntityDataRepository,
            IEntityIdFactory<SubPartofHsCode> EntityIdFactory,
            IEntityFileFactory<SubPartofHsCode> entityFileFactory,
            IEntityBlobStorage<SubPartofHsCode> entityBlobStorage,
            DicConvertFactory<SubPartofHsCode> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<SubPartofHsCode> CreateAsync(SubPartofHsCode entity)
        {
            return await base.CreateAsync(entity);
        }
    }
    public class AgreetMentManager : EntityManager<AgreetMent>
    {
        public AgreetMentManager(IEntityDataRepository<AgreetMent> EntityDataRepository,
            IEntityIdFactory<AgreetMent> EntityIdFactory,
            IEntityFileFactory<AgreetMent> entityFileFactory,
            IEntityBlobStorage<AgreetMent> entityBlobStorage,
            DicConvertFactory<AgreetMent> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<AgreetMent> CreateAsync(AgreetMent entity)
        {
            return await base.CreateAsync(entity);
        }
    }
    public class CountryManager : EntityManager<Country>
    {
        public CountryManager(IEntityDataRepository<Country> EntityDataRepository,
            IEntityIdFactory<Country> EntityIdFactory,
            IEntityFileFactory<Country> entityFileFactory,
            IEntityBlobStorage<Country> entityBlobStorage,
            DicConvertFactory<Country> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<Country> CreateAsync(Country entity)
        {
            return await base.CreateAsync(entity);
        }
    }
    public class ClearanceInfoofHsCodeManager : EntityManager<ClearanceInfoofHsCode>
    {
        public ClearanceInfoofHsCodeManager(IEntityDataRepository<ClearanceInfoofHsCode> EntityDataRepository,
            IEntityIdFactory<ClearanceInfoofHsCode> EntityIdFactory,
            IEntityFileFactory<ClearanceInfoofHsCode> entityFileFactory,
            IEntityBlobStorage<ClearanceInfoofHsCode> entityBlobStorage,
            DicConvertFactory<ClearanceInfoofHsCode> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<ClearanceInfoofHsCode> CreateAsync(ClearanceInfoofHsCode entity)
        {
            return await base.CreateAsync(entity);
        }
    }
}
