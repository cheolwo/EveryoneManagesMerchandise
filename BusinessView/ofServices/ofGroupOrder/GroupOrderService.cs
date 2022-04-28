using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofGroupOrder
{
    public class GroupOrderService : DTOService
    {
        public GroupOrderService(Action<DTOServiceOptions> options)
        {
            options.Invoke(_options);
            if (_options.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.GroupOrderWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
