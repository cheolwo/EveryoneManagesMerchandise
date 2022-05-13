namespace BusinessView.ofStorage.ofEmployer
{
    public class EmployerMarketNMemoryDatabase : Database
    {
        public EmployerMarketNMemoryDatabase()
        {
            var employerMarkets = this.Tables.Create<EmployerMarket, string>(x=>x.Id, null);
            var employerPlatMarkets = this.Tables.Create<EmployerPlatMarket, string>(x=>x.Id, null);
            var employerMCommoditys = this.Tables.Create<EmployerMCommodity, string>(x=>x.Id, null);
            var employerSMCommoditys = this.Tables.Create<EmployerSMCommodity, string>(x=>x.Id, null);
            var employerMMCommoditys = this.Tables.Create<EmployerMMCommodity, string>(x=>x.Id, null);
            var employerEMCommoditys = this.Tables.Create<EmployerEMCommodity, string>(x=>x.Id, null);

            employerMarkets = EmployerMarkets;
            employerPlatMarkets = EmployerPlatMarkets;
            employerMCommoditys = EmployerMCommoditys;
            employerMMCommoditys = EmployerMMCommoditys;
            employerSMCommoditys = EmployerSMCommoditys;
            employerEMCommoditys = EmployerEMCommoditys;
        }
        public ITable<EmployerMarket> EmployerMarkets {get; private set;}
        public ITable<EmployerPlatMarket> EmployerPlatMarkets {get; private set;}
        public ITable<EmployerMCommodity> EmployerMCommoditys {get; private set;}
        public ITable<EmployerSMCommodity> EmployerSMCommoditys {get; private set;}
        public ITable<EmployerMMCommodity> EmployerMMCommoditys {get; private set;}
        public ITable<EmployerEMCommodity> EmployerEMCommoditys {get; private set;}
    }
}