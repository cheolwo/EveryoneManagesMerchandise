namespace BusinessView.ofStorage.ofEmployer
{
    public class EmployerOrderNMemoryDatabase : Database
    {
        public EmployerOrderNMemoryDatabase()
        {
            var employerOrderCenters = this.Tables.Create<EmployerOrderCenter, string>(x=>x.Id, null);
            var employerOCommoditys = this.Tables.Create<EmployerOCommodity, string>(x=>x.Id, null);
            var employerSOCommoditys = this.Tables.Create<EmployerSOCommodity, string>(x=>x.Id, null);
            var employerMOCommoditys = this.Tables.Create<EmployerMOCommodity, string>(x=>x.Id, null);
            var employerEOCommoditys = this.Tables.Create<EmployerEOCommodity, string>(x=>x.Id, null);

            employerOrderCenters = EmployerOrderCenters;
            employerOCommoditys = EmployerOCommoditys;
            employerSOCommoditys = EmployerSOCommoditys;
            employerMOCommoditys = EmployerMOCommoditys;
            employerEOCommoditys = EmployerEOCommoditys;
        }
        public ITable<EmployerOrderCenter> EmployerOrderCenters {get; private set;}
        public ITable<EmployerOCommodity> EmployerOCommoditys {get; private set;}
        public ITable<EmployerSOCommodity> EmployerSOCommoditys {get; private set;}
        public ITable<EmployerMOCommodity> EmployerMOCommoditys {get; private set;}
        public ITable<EmployerEOCommodity> EmployerEOCommoditys {get; private set;}
    }
}