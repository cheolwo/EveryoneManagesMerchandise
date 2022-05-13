namespace BusinessView.ofStorage.ofEmployer
{
    public class EmployerJournalNMemoryDatabase : Database
    {
        public EmployerJournalNMemoryDatabase()
        {
            var employerJournalCenters = this.Tables.Create<EmployerJournalCenter, string>(x=>x.Id, null);
            var employerJCommoditys = this.Tables.Create<EmployerJCommodity, string>(x=>x.Id, null);
            var employerJournals = this.Tables.Create<EmployerJournal, string>(x=>x.Id, null);

            employerJournalCenters = EmployerJournalCenters;
            employerJCommoditys = EmployerJCommoditys;
            employerJournals = EmployerJournals;
        }
        public ITable<EmployerJournalCenter> EmployerJournalCenters {get; private set;}
        public ITable<EmployerJCommodity> EmployerJCommoditys {get; private set;}
        public ITable<EmployerJournal> EmployerJournals {get; private set;}
    }
}