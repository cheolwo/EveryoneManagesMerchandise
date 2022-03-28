using BusinessData.ofGeneric.ofIdFactory;
using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofProduct
{
    public interface IMPCommodityManager : IMStatusManager<MPCommodity>
    {

    }
    public class MPCommodityManager : MStatusManager<MPCommodity>, IEmployerMPCommodityManager, IEmployeeMPCommodityManager, IPlatformMPCommodityManager
    {
        private readonly IMPCommodityRepository _MPCommodityRepository;
        public MPCommodityManager(IMPCommodityRepository MPCommodityRepository,
                               IMPCommodityIdFactory MPCommodityIdFactory,
                               IMPCommodityFileFactory MPCommodityFileFactory,
                               IMPCommodityBlobStorage blobStorage,
                            DicConvertFactory<MPCommodity> dicConvertFactory)
            : base(MPCommodityRepository, MPCommodityIdFactory, MPCommodityFileFactory, blobStorage, dicConvertFactory)
        {
            _MPCommodityRepository = MPCommodityRepository;
        }

        public Task<string> CreateIdByRelationEntity(MPCommodity entity)
        {
            throw new System.NotImplementedException();
        }

        public List<MPCommodity> SetEntityId(List<MPCommodity> entities, int count)
        {
            throw new System.NotImplementedException();
        }

    }
}