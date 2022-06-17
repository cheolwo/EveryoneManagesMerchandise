﻿using BusinessData.ofPresentationLayer.ofDTO.ofJournal.ofEmployer;
using BusinessView.ofViewModels.ofWebApp.ofJournal.ofJournal;

namespace BusinessView.ofViewModels.ofWebApp.ofEmployer.ofJournal.ofJournal
{
    public class EmployerJournalPageViewModel : JournalPageViewModel<EmployerJournal> 
    {
        public readonly EmployerPostJournalViewModel _EmployerPostJournalViewModel;
        public readonly EmployerPutJournalViewModel _EmployerPutJournalViewModel;
        public readonly EmployerDeleteJournalViewModel _EmployerDeleteJournalViewModel;
        public readonly EmployerGetsJournalViewModel _EmployerGetsJournalViewModel;

        public EmployerJournalPageViewModel(EmployerPostJournalViewModel EmployerPostJournalViewModel, 
                                        EmployerPutJournalViewModel EmployerPutJournalViewModel,
                                        EmployerDeleteJournalViewModel EmployerDeleteJournalViewModel,
                                        EmployerGetsJournalViewModel EmployerGetsJournalViewModel)
                :base(EmployerPostJournalViewModel, EmployerPutJournalViewModel, EmployerDeleteJournalViewModel, EmployerGetsJournalViewModel)
                    
        {
            _EmployerPostJournalViewModel = EmployerPostJournalViewModel;
            _EmployerPutJournalViewModel = EmployerPutJournalViewModel;
            _EmployerDeleteJournalViewModel = EmployerDeleteJournalViewModel;
            _EmployerGetsJournalViewModel = EmployerGetsJournalViewModel;
        }
    }
}