namespace BusinessView.ofStorage.ofEmployer
{
    public class EmployerHRNMemoryDatabase : Database
    {
        public EmployerHRNMemoryDatabase()
        {
            var employerHRCenters = this.Tables.Create<EmployerHRCenter, string>(x=>x.Id, null);
            var employerHRBusinessParts = this.Tables.Create<EmployerHRBusinessPart, string>(x=>x.Id, null);
            var employerHREmployees = this.Tables.Create<EmployerHREmployee, string>(x=>x.Id, null);
            var employerHRRoles = this.Tables.Create<EmployerHRRole, string>(x=>x.Id, null);
            var employerEmployeeRoles = this.Tables.Create<EmployerEmployeeRole, string>(x=>x.Id, null);

            employerHRCenters = EmployerHRCeners;
            employerHRBusinessParts = EmployerHRBusinessParts;
            employerHREmployees = EmployerHREmployees;
            employerHRRoles = EmployerHRRoles;
            employerEmployeeRoles = EmployerHREmployees;
        }
        public ITable<EmployerEmployeeRole> EmployerEmployeeRoles {get; private set;}
        public ITable<EmployerHRCener> EmployerHRCeners {get; private set;}
        public ITable<EmployerHRRole> EmployerHRRoles {get; private set;}
        public ITable<EmployerHRBusinessPart> EmployerHRBusinessParts {get; private set;}
        public ITable<EmployerHREmployee> EmployerHREmployees {get; private set;}
    }
}