using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;

namespace BusinessView.ofDTO.ofJournal.ofPlatform
{
    [AutoMap(typeof(Journal))]
    public class PlatformJournal : JournalDTO
    {
       
    }
}
