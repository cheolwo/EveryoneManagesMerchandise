using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofHR
{
    public class HRServiceOptions : DTOServiceOptions
    {

    }
    public class HRService : DTOService 
    {
        protected HRServiceOptions _HRServiceOptions;
        public HRService(HRServiceOptions options)
            :base(options)
        {
            _HRServiceOptions = options;
            if (_HRServiceOptions.IsDevelopment)
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
