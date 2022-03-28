using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofProduct.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofProduct
{
    public interface IProductCenterManager : ICenterManager<ProductCenter>
    {

    }
    public class ProductCenterManager : CenterManager<ProductCenter>, IEmployerProductCenterManager, IEmployeeProductCenterManager, IPlatformProductCenterManager
    {
        private readonly IProductCenterRepository _ProductCenterRepository;
        public ProductCenterManager(IProductCenterRepository ProductCenterRepository,
                               IProductCenterIdFactory ProductCenterIdFactory,
                               IProductCenterFileFactory ProductCenterFileFactory,
                               IProductCenterBlobStorage blobStorage,
                               CenterPasswordHasher<ProductCenter> centerPasswordHasher,
                            DicConvertFactory<ProductCenter> dicConvertFactory)
            : base(ProductCenterRepository, ProductCenterIdFactory, ProductCenterFileFactory, blobStorage, dicConvertFactory, centerPasswordHasher)
        {
            _ProductCenterRepository = ProductCenterRepository;
        }
        
    }
}