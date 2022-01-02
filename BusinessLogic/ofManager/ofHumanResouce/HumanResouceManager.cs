using BusinessData.ofHRCenter.ofRepository;
using BusinessData.ofHumanResouce.ofIdFactory;
using BusinessData.ofHumanResource.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofHumanResouce
{
    public interface IHRCenterManager : ICenterManager<HRCenter>
    {

    }
    public class HRCenterManager : CenterManager<HRCenter>, IHRCenterManager
    {
        public HRCenterManager(IHRCenterRepository HRCenterRepository, IHRCenterIdFactory hRCenterIdFactory, IHRCenterFileFactory HRCenterFileFactory,
           IHRCenterBlobStorage entityBlobStorage,
         DicConvertFactory<HRCenter> dicConvertFactory, CenterPasswordHasher<HRCenter> centerPasswordHasher)
            : base(HRCenterRepository, hRCenterIdFactory, HRCenterFileFactory, entityBlobStorage, dicConvertFactory, centerPasswordHasher)
        {

        }
    }
    public interface IHREmployeeManager : IEntityManager<HREmployee>
    {

    }
    public class HREmployeeManager : EntityManager<HREmployee>, IHREmployeeManager
    {
        public HREmployeeManager(IHREmployeeRepository HREmployeeRepository, IHREmployeeIdFactory hREmployeeIdFactory, IHREmployeeFileFactory HREmployeeFileFactory,
        IHREmployeeBlobStorage entityBlobStorage, DicConvertFactory<HREmployee> dicConvertFactory)
            : base(HREmployeeRepository, hREmployeeIdFactory, HREmployeeFileFactory, entityBlobStorage, dicConvertFactory)
        {

        }
    }
    public interface IHRRoleManager : IEntityManager<HRRole>
    {

    }
    public class HRRoleManager : EntityManager<HRRole>, IHRRoleManager
    {
        public HRRoleManager(IHRRoleRepository HRRoleRepository, IHRRoleIdFactory hRRoleIdFactory, IHRRoleFileFactory HRRoleFileFactory,
        IHRRoleBlobStorage entityBlobStorage, DicConvertFactory<HRRole> dicConvertFactory)
            : base(HRRoleRepository, hRRoleIdFactory, HRRoleFileFactory, entityBlobStorage, dicConvertFactory)
        {

        }
    }
    public interface IEmployeeRoleManager : IEntityManager<EmployeeRole>
    {

    }
    public class EmployeeRoleManager : EntityManager<EmployeeRole>, IEmployeeRoleManager
    {
        public EmployeeRoleManager(IEmployeeRoleRepository EmployeeRoleRepository, IEmployeeRoleIdFactory employeeRoleIdFactory, IEmployeeRoleFileFactory EmployeeRoleFileFactory,
        IEmployeeRoleBlobStorage entityBlobStorage, DicConvertFactory<EmployeeRole> dicConvertFactory)
            : base(EmployeeRoleRepository, employeeRoleIdFactory, EmployeeRoleFileFactory, entityBlobStorage, dicConvertFactory)
        {

        }
    }
}
