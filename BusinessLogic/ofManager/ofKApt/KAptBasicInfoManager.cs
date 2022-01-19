using BusinessData;
using BusinessData.ofCommon.ofKapt;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using System.Threading.Tasks;

namespace BusinessLoogic.ofManager.ofKApt
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