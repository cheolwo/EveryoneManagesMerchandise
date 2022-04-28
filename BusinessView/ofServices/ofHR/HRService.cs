using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofHR
{
    public class HRService : DTOService
    {
        public HRService(Action<DTOServiceOptions> options)
        {
            options.Invoke(_options);
            if (_options.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.HRWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
