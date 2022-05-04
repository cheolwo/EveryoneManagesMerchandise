using BusinessView.ofCommon;
using BusinessView.ofCommon.ofServices;

namespace BusinessView.ofServices.ofJournal
{
    public class JournalServiceOptions : DTOServiceOptions
    {

    }
    public class JournalService : DTOService
    {
        protected JournalServiceOptions _JournalServiceOptions;
        public JournalService(JournalServiceOptions options)
            :base(options)
        {
            _JournalServiceOptions = options;
            if (_JournalServiceOptions.IsDevelopment)
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
