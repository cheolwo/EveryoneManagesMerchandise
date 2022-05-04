using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofGroupOrder
{
    public class GroupOrderServiceOptions : DTOServiceOptions
    {

    }
    public class GroupOrderService : DTOService
    {
        protected GroupOrderServiceOptions _GroupOrderServiceOptions;
        public GroupOrderService(GroupOrderServiceOptions options)
            :base(options)
        {
            _GroupOrderServiceOptions = options;
            if (_GroupOrderServiceOptions.IsDevelopment)
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
