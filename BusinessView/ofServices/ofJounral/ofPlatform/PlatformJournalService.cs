using BusinessView.ofDTO.ofJournal.ofPlatform;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofPlatform
{
    public class PlatformJournalService : JournalService
    {
        public PlatformJournalService(JournalServiceOptions options)
            : base(options)
        {

        }

    }
}
