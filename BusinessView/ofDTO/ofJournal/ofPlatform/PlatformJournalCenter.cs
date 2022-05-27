using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofPlatform;
using System.ComponentModel.DataAnnotations;
using BusinessData.ofFinancial.Model;
using BusinessData;

namespace BusinessView.ofDTO.ofJournal.ofPlatform
{
    [AutoMap(typeof(JournalCenter))]
    public class PlatformJournalCenter : JournalCenterDTO
    {
        
    }
}
