using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofTrade
{
    public class TradeService : DTOService
    {
        public TradeService(Action<DTOServiceOptions> options)
        {
            options.Invoke(_options);
            if (_options.IsDevelopment)
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
