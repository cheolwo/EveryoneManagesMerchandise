using AutoMapper;
using BusinessView.ofDTO.ofCommon.ofEmployer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessData.ofJournal;
using BusinessData;
using BusinessData.ofFinancial.Model;
namespace BusinessView.ofDTO.ofJournal.ofEmployer
{
    [AutoMap(typeof(JournalCenter))]
    public class EmployerJournalCenter : JournalCenterDTO
    {
    }
}
