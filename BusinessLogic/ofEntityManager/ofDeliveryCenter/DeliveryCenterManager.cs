using BusinessData.ofDeliveryCenter;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofDeliveryCenter.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.ofManager.ofDeliveryCenter
{
    public interface IDeliveryCenterManager : ICenterManager<DeliveryCenter>
    {

    }
    [DataManager(typeof(DeliveryCenter))]
    public class DeliveryCenterManager : CenterManager<DeliveryCenter>, IEmployerDeliveryCenterManager, IEmployeeDeliveryCenterManager, IPlatformDeliveryCenterManager, IDeliveryCenterManager
    {   
        public DeliveryCenterManager(IDeliveryCenterRepository deliveryCenterRepository, 
            IDeliveryCenterIdFactory deliveryCenterIdFactory,
                            IDeliveryCenterFileFactory deliveryCenterFileFactory,
                            IDeliveryCenterBlobStorage blobStorage,
                            DicConvertFactory<DeliveryCenter> dicConvertFactory,
                            CenterPasswordHasher<DeliveryCenter> centerPasswordHasher)
            : base(deliveryCenterRepository, deliveryCenterIdFactory, deliveryCenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {

        }
    }
}