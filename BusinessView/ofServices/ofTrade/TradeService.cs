using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofTrade
{
    public class TradeServiceOptions : DTOServiceOptions
    {

    }
    public class TradeService : DTOService
    {
        protected TradeServiceOptions _TradeServiceOptions;
        public TradeService(TradeServiceOptions options)
            :base(options)
        {
            _TradeServiceOptions = options;
            if (_TradeServiceOptions.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.TradeWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
