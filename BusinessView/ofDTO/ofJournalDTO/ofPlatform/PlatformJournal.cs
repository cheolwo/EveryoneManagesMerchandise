﻿using BusinessView.ofCommon.ofPlatform;

namespace BusinessView.ofDTO.ofJournalDTO.ofPlatform
{
    public class PlatformJournal : PlatformEntity
    {
        public string Debits { get; set; }         // Json 으로 처리한다.
        public string Credits {get; set; }       // Json 으로 처리한다.
        public string AwesomeInfo {get; set;}
        public string JCommodity {get; set;}
    }
}