﻿using BusinessView.ofDTO.ofJournal.ofEmployee;
using BusinessView.ofServices.ofJournal;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessView.ofCommon.ofServices.ofJournal.ofEmployee
{
    public class EmployeeJournalService : JournalService
    {
        public EmployeeJournalService(JournalServiceOptions options)
            : base(options)
        {

        }

       
    }
}
