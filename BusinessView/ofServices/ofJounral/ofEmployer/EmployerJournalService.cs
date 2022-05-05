using BusinessView.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployer
{
    public class EmployerJournalService : JournalService
    {
        public EmployerJournalService(JournalServiceOptions options)
            : base(options)
        {

        }

       
    }
}
