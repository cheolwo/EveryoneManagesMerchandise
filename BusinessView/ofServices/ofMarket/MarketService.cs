using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofMarket
{
    public class MarketServiceOptions : DTOServiceOptions
    {
        
    }
    public class MarketService : DTOService
    {
        protected MarketServiceOptions _MarketServiceOptions;
        public MarketService(MarketServiceOptions options)
            :base(options)
        {
            _MarketServiceOptions = options;
            if (_MarketServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.MarketWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
