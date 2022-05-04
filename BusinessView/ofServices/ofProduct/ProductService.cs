using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofProduct
{
    public class ProductServiceOptions : DTOServiceOptions
    {

    }
    public class ProductService : DTOService
    {
        protected ProductServiceOptions _ProductServiceOptions;
        public ProductService(ProductServiceOptions options)
            :base(options)
        {
            _ProductServiceOptions = options;
            if (_ProductServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.ProductWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
