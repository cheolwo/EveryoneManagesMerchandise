namespace BusinessView.ofStorage.ofEmployer
{
    public class EmployerWarehouseNMemoryDatabase : Database
    {
        public EmployerWarehouseNMemoryDatabase()
        {
            var employerWarehouses = this.Tables.Create<EmployerWarehouse, string>(x=>x.Id, null);
            var employerWCommoditys = this.Tables.Create<EmployerWCommodity, string>(x=>x.Id, null);
            var employerSWCommoditys = this.Tables.Create<EmployerSWCommodity, string>(x=>x.Id, null);
            var employerMWCommoditys = this.Tables.Create<EmployerMWCommodity, string>(x=>x.Id, null);
            var employerEWCommoditys = this.Tables.Create<EmployerEWCommodity, string>(x=>x.Id, null);
            var employerWorkingDesks = this.Tables.Create<EmployerWorkingDesk, string>(x=>x.Id, null);
            var employerLodaFrames = this.Tables.Create<EmployerLodaFrame, string>(x=>x.Id, null);
            var employerDividedTags = this.Tables.Create<EmployerDividedTag, string>(x=>x.Id, null);
            var employerDotBarcodes = this.Tables.Create<EmployerDotBarcode, string>(x=>x.Id, null);
            var employerIncomingTags = this.Tables.Create<EmployerIncomingTag, string>(x=>x.Id, null);

            employerWarehouses = EmployerWarehouses;
            employerWCommoditys = EmployerWCommoditys;
            employerSWCommoditys = EmployerSWCommoditys;
            employerMWCommoditys = EmployerMWCommoditys;
            employerEWCommoditys = EmployerEWCommoditys;
            employerWorkingDesks = EmployerWorkingDesks;
            employerLodaFrames = EmployerLodaFrames;
            employerDividedTags = EmployerDividedTags;
            employerDotBarcodes = EmployerDotBarcodes;
            employerIncomingTags = EmployerIncomingTags;
        }
        public ITable<EmployerIncomingTag> EmployerIncomingTags {get; private set;}
        public ITable<EmployerDotBarcode> EmployerDotBarcodes {get; private set;}
        public ITable<EmployerDividedTag> EmployerDividedTags {get; private set;}
        public ITable<EmployerLodaFrame> EmployerLodaFrames {get; private set;}
        public ITable<EmployerWorkingDesk> EmployerWorkingDesks {get; private set;}
        public ITable<EmployerWarehouse> EmployerWarehouses {get; private set;}
        public ITable<EmployerWCommodity> EmployerWCommoditys {get; private set;}
        public ITable<EmployerSWCommodity> EmployerSWCommoditys {get; private set;}
        public ITable<EmployerMWCommodity> EmployerMWCommoditys {get; private set;}
        public ITable<EmployerEWCommodity> EmployerEWCommoditys {get; private set;}
    }
}