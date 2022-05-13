namespace BusinessView.ofStorage.ofEmployer
{
    public class EmployerProductNMemoryDatabase : Database
    {
        public EmployerProductNMemoryDatabase()
        {
            var employerProductCenters = this.Tables.Create<EmployerProductCenter, string>(x=>x.Id, null);
            var employerPCommoditys = this.Tables.Create<EmployerPCommodity, string>(x=>x.Id, null);
            var employerSPCommoditys = this.Tables.Create<EmployerSPCommodity, string>(x=>x.Id, null);
            var employerMPCommoditys = this.Tables.Create<EmployerMPCommodity, string>(x=>x.Id, null);
            var employerEPCommoditys = this.Tables.Create<EmployerEPCommodity, string>(x=>x.Id, null);
            var employerProductLands = this.Tables.Create<EmployerProductLand, string>(x=>x.Id, null);
            var employerProducters = this.Tables.Create<EmployerProducter, string>(x=>x.Id, null);

            employerProductCenters = EmployerProductCenters;
            employerPCommoditys = EmployerPCommoditys;
            employerSPCommoditys= EmployerSPCommoditys;
            employerMPCommoditys = EmployerMPCommoditys;
            employerEPCommoditys = EmployerEPCommoditys;
            employerProductLands = EmployerProductLands;
            employerProducters = EmployerProducters;
        }
        public ITable<EmployerProductCenter> EmployerProductCenters {get; private set;}
        public ITable<EmployerPCommodity> EmployerPCommoditys {get; private set;}
        public ITable<EmployerSPCommodity> EmployerSPCommoditys {get; private set;}
        public ITable<EmployerMPCommodity> EmployerMPCommoditys {get; private set;}
        public ITable<EmployerEPCommodity> EmployerEPCommoditys {get; private set;}
        public ITable<EmployerProductLand> EmployerProductLands {get; private set;}
        public ITable<EmployerProducter> EmployerProducters {get; private set;}
    }
}