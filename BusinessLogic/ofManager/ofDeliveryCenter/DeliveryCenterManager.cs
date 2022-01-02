using BusinessData.ofDeliveryCenter;
using BusinessData.ofRepository;
using BusinessLogic.ofManager.ofDeliveryCenter.ofBlobStorage;
using BusinessLogic.ofManager.ofDeliveryCenter.ofFileFactory;
using BusinessLogic.ofManager.ofDeliveryCenter.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric;
using Microsoft.AspNetCore.Identity;

namespace BusinessLogic.ofManager.ofDeliveryCenter
{
    [DataManager(typeof(DeliveryCenter))]
    public class DeliveryCenterManager : CenterManager<DeliveryCenter>
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