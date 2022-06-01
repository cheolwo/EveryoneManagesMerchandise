using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;

namespace BusinessView.ofDTO.ofJournal.ofEmployee
{
    [AutoMap(typeof(JournalCenter))]
    public class EmployeeJournalCenter : JournalCenterDTO
    {
        
    }
}
