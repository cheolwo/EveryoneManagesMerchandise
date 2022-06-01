using BusinessData.ofHRCenter.ofRepository;
using BusinessData.ofHumanResouce.ofIdFactory;
using BusinessData.ofHumanResource.ofRepository;
using BusinessLogic.ofManager.ofGeneric;
using BusinessLogic.ofManager.ofHumanResouce.ofInterface.ofEmployee;
using BusinessLogic.ofManager.ofHumanResouce.ofInterface.ofEmployer;
using BusinessLogic.ofManager.ofHumanResouce.ofInterface.ofPlatform;
using BusinessLogic.ofManager.ofWarehouse.ofBlobStorage;
using BusinessLogic.ofManager.ofWarehouse.ofFileFactory;

namespace BusinessLogic.ofManager.ofHumanResouce
{
    public interface IHRCenterManager : ICenterManager<HRCenter>
    {

    }
    public class HRCenterManager : CenterManager<HRCenter>, IEmployerHRCenterManager, IEmployeeHRCenterManager, IPlatformHRCenterManager, IHRCenterManager
    {
        public HRCenterManager(IHRCenterRepository HRCenterRepository, 
        IHRCenterIdFactory hRCenterIdFactory, 
        IHRCenterFileFactory HRCenterFileFactory,
           IHRCenterBlobStorage entityBlobStorage,
         DicConvertFactory<HRCenter> dicConvertFactory, CenterPasswordHasher<HRCenter> centerPasswordHasher)
            : base(HRCenterRepository, hRCenterIdFactory, HRCenterFileFactory, entityBlobStorage, dicConvertFactory, centerPasswordHasher)
        {

        }
    }
    public interface IHREmployeeManager : IEntityManager<HREmployee>
    {

    }
    public class HREmployeeManager : EntityManager<HREmployee>, IEmployerHREmployeeManager, IEmployeeHREmployeeManager, IPlatformHREmployeeManager, IHREmployeeManager
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
    public class HRRoleManager : EntityManager<HRRole>, IEmployerHRRoleManager, IEmployeeHRRoleManager, IPlatformHRRoleManager, IHRRoleManager
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
    public class EmployeeRoleManager : EntityManager<EmployeeRole>, IEmployerEmployeeRoleManager, IEmployeeEmployeeRoleManager, IPlatformEmployeeRoleManager, IEmployeeRoleManager
    {
        public EmployeeRoleManager(IEmployeeRoleRepository EmployeeRoleRepository, IEmployeeRoleIdFactory employeeRoleIdFactory, IEmployeeRoleFileFactory EmployeeRoleFileFactory,
        IEmployeeRoleBlobStorage entityBlobStorage, DicConvertFactory<EmployeeRole> dicConvertFactory)
            : base(EmployeeRoleRepository, employeeRoleIdFactory, EmployeeRoleFileFactory, entityBlobStorage, dicConvertFactory)
        {

        }
    }
    public interface IHRBusinessPartManager : IEntityManager<HRBusinessPart>
    {

    }
    public class HRBusinessPartManager : EntityManager<HRBusinessPart>, IEmployerHRBusinessPartManager, IEmployeeHRBusinessPartManager, IPlatformHRBusinessPartManager, IHRBusinessPartManager
    {
        public HRBusinessPartManager(IHRBusinessPartRepository HRBusinessPartRepository, IHRBusinessPartIdFactory HRBusinessPartIdFactory, IHRBusinessPartFileFactory HRBusinessPartFileFactory,
        IHRBusinessPartBlobStorage entityBlobStorage, DicConvertFactory<HRBusinessPart> dicConvertFactory)
            : base(HRBusinessPartRepository, HRBusinessPartIdFactory, HRBusinessPartFileFactory, entityBlobStorage, dicConvertFactory)
        {

        }
    }
}
