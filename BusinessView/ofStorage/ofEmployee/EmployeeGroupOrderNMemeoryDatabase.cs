namespace BusinessView.ofStorage.ofEmployee
{
    public class EmployeeGroupOrderNMemoryDatabase : Database
    {
        public EmployeeGroupOrderNMemoryDatabase()
        {
            var _EmployeeGOCS = this.Tables.Create<EmployeeGOCS, string>(x => x.Id, null);
            var _EmployeeGOCCS = this.Tables.Create<EmployeeGOCCS, string>(x => x.Id, null);
            var _EmployeeSGOCS = this.Tables.Create<EmployeeSGOCS, string>(x => x.Id, null);
            var _EmployeeMGOCS = this.Tables.Create<EmployeeMGOCS, string>(x => x.Id, null);
            var _EmployeeEGOCS = this.Tables.Create<EmployeeEGOCS, string>(x => x.Id, null);

            EmployeeGOCS = _EmployeeGOCS;
            EmployeeGOCCS = _EmployeeGOCCS;
            EmployeeSGOCS = _EmployeeSGOCS;
            EmployeeMGOCS = _EmployeeMGOCS;
            EmployeeEGOCS = _EmployeeEGOCS;
        }
        public ITable<EmployeeGOC> EmployeeGOCS {get; private set;}
        public ITable<EmployeeGOCC> EmployeeGOCCS {get; private set;}
        public ITable<EmployeeSGOC> EmployeeSGOCS {get; private set;}
        public ITable<EmployeeMGOC> EmployeeMGOCS {get; private set;}
        public ITable<EmployeeEGOC> EmployeeEGOCS {get; private set;}
    }
}