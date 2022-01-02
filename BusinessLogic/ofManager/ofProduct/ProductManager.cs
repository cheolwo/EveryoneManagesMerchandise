using BusinessData.ofMarket.ofRepository.ofIdFactory;
using BusinessData.ofProduct;
using BusinessData.ofProduct.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofProduct.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofProduct
{
    public class ProductCenterManager : CenterManager<ProductCenter>
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