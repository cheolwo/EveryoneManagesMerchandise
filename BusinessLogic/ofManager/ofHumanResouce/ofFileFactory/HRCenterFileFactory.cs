using BusinessData.ofHumanResource.ofRepository;
using BusinessData.ofWarehouse.Model;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;

namespace BusinessLogic.ofManager.ofWarehouse.ofFileFactory
{
    public interface IHRCenterFileFactory : ICenterFileFactory<HRCenter>
    {

    }
    public class HRCenterFileFactory : CenterFileFactory<HRCenter>, IHRCenterFileFactory
    {

    }
    public interface IHREmployeeFileFactory : IEntityFileFactory<HREmployee>
    {

    }
    public class HREmployeeFileFactory : EntityFileFactory<HREmployee>, IHREmployeeFileFactory
    {

    }
    public interface IHRRoleFileFactory : IEntityFileFactory<HRRole>
    {

    }
    public class HRRoleFileFactory : EntityFileFactory<HRRole>, IHRRoleFileFactory
    {

    }
    public interface IEmployeeRoleFileFactory : IEntityFileFactory<EmployeeRole>
    {

    }
    public class EmployeeRoleFileFactory : EntityFileFactory<EmployeeRole>, IEmployeeRoleFileFactory
    {

    }
}