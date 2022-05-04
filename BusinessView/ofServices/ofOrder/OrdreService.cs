using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofOrder
{
    public class OrderServiceOptions : DTOServiceOptions
    {

    }
    public class OrderService : DTOService
    {
        protected OrderServiceOptions _OrderServiceOptions;
        public OrderService(OrderServiceOptions options)
            :base(options)
        {
            _OrderServiceOptions = options;
            if (_OrderServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.OrderWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
