using BusinessData.ofCommon.ofKapt;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofExternalManager.ofKApt
{
    public class KAptBasicInfoManager : EntityManager<KAptBasicInfo>
    {
        public KAptBasicInfoManager(IEntityDataRepository<KAptBasicInfo> EntityDataRepository, 
            IEntityIdFactory<KAptBasicInfo> EntityIdFactory,
            IEntityFileFactory<KAptBasicInfo> entityFileFactory, 
            IEntityBlobStorage<KAptBasicInfo> entityBlobStorage, 
            DicConvertFactory<KAptBasicInfo> dicConvertFactory) : base(EntityDataRepository, EntityIdFactory, entityFileFactory, entityBlobStorage, dicConvertFactory)
        {
        }
        public override async Task<KAptBasicInfo> CreateAsync(KAptBasicInfo entity)
        {
            return await _EntityDataRepository.AddAsync(entity);
        }
    }
}