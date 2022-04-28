using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofJournal
{
    public class JournalService : DTOService
    {
        public JournalService(Action<DTOServiceOptions> options)
        {
            options.Invoke(_options);
            if (_options.IsDevelopment)
            {
                _httpClient.BaseAddress = new Uri(DevelopmentServerBaseAddress.JournalWebAPIServerURL);
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}
