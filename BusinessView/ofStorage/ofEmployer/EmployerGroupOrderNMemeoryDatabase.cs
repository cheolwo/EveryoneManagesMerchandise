namespace BusinessView.ofStorage.ofEmployer.ofGroupOrder
{
    public class EmployerGroupOrderNMemoryDatabase : Database
    {
        public EmployerGroupOrderNMemoryDatabase()
        {
            var _EmployerGOCS = this.Tables.Create<EmployerGOCS, string>(x => x.Id, null);
            var _EmployerGOCCS = this.Tables.Create<EmployerGOCCS, string>(x => x.Id, null);
            var _EmployerSGOCS = this.Tables.Create<EmployerSGOCS, string>(x => x.Id, null);
            var _EmployerMGOCS = this.Tables.Create<EmployerMGOCS, string>(x => x.Id, null);
            var _EmployerEGOCS = this.Tables.Create<EmployerEGOCS, string>(x => x.Id, null);

            EmployerGOCS = _EmployerGOCS;
            EmployerGOCCS = _EmployerGOCCS;
            EmployerSGOCS = _EmployerSGOCS;
            EmployerMGOCS = _EmployerMGOCS;
            EmployerEGOCS = _EmployerEGOCS;
        }
        public ITable<EmployerGOC> EmployerGOCS {get; private set;}
        public ITable<EmployerGOCC> EmployerGOCCS {get; private set;}
        public ITable<EmployerSGOC> EmployerSGOCS {get; private set;}
        public ITable<EmployerMGOC> EmployerMGOCS {get; private set;}
        public ITable<EmployerEGOC> EmployerEGOCS {get; private set;}
    }
}