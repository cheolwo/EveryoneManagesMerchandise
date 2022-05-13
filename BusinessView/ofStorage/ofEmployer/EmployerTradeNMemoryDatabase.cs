namespace BusinessView.ofStorage.ofEmployer
{
    public class EmployerTradeNMemoryDatabase : Database
    {
        public EmployerTradeNMemoryDatabase()
        {
            var employerTradeCenters = this.Tables.Create<EmployerTradeCenter, string>(x=>x.Id, null);
            var employerTCommoditys = this.Tables.Create<EmployerTCommodity, string>(x=>x.Id, null);
            var employerSTCommoditys = this.Tables.Create<EmployerSTCommodity, string>(x=>x.Id, null);
            var employerMTCommoditys = this.Tables.Create<EmployerMTCommodity, string>(x=>x.Id, null);
            var employerETCommoditys = this.Tables.Create<EmployerETCommodity, string>(x=>x.Id, null);
            
            employerTradeCenters = EmployerTradeCenters;
            employerTCommoditys = EmployerTCommoditys;
            employerSTCommoditys = EmployerSTCommoditys;
            employerMTCommoditys = EmployerMTCommoditys;
            employerETCommoditys = EmployerETCommoditys;
        }
        public ITable<EmployerTradeCenter> EmployerTradeCenters {get; private set;}
        public ITable<EmployerTCommodity> EmployerTCommoditys {get; private set;}
        public ITable<EmployerSTCommodity> EmployerSTCommoditys {get; private set;}
        public ITable<EmployerMTCommodity> EmployerMTCommoditys {get; private set;}
        public ITable<EmployerETCommodity> EmployerETCommoditys {get; private set;}
    }
}