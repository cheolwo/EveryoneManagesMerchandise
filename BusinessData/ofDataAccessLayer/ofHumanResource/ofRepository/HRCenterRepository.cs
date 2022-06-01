using BusinessData.ofHR.ofDbContext;
using BusinessData.ofHumanResource.ofInterface.ofEmployee;
using BusinessData.ofHumanResource.ofInterface.ofEmployer;
using BusinessData.ofHumanResource.ofInterface.ofPlatform;
using BusinessData.ofHumanResource.ofRepository;

namespace BusinessData.ofHRCenter.ofRepository
{
    public interface IHRCenterRepository : ICenterDataRepository<HRCenter>
    {
    }

    public class HRCenterRepository : CenterDataRepository<HRCenter>, IHRCenterRepository, IEmployeeHRCenterRepository, IEmployerHRCenterRepository, IPlatformHRCenterRepository
    {
        public HRCenterRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
    public interface IHREmployeeRepository : IEntityDataRepository<HREmployee>
    {
    }

    public class HREmployeeRepository : EntityDataRepository<HREmployee>, IHREmployeeRepository, IEmployeeHREmployeeRepository, IEmployerHREmployeeRepository, IPlatformHREmployeeRepository
    {
        public HREmployeeRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
    public interface IHRRoleRepository : IEntityDataRepository<HRRole>
    {
    }

    public class HRRoleRepository : EntityDataRepository<HRRole>, IHRRoleRepository, IEmployeeHRRoleRepository, IEmployerHRRoleRepository, IPlatformHRRoleRepository
    {
        public HRRoleRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
    public interface IEmployeeRoleRepository : IEntityDataRepository<EmployeeRole>
    {
    }

    public class EmployeeRoleRepository : EntityDataRepository<EmployeeRole>, IEmployeeRoleRepository, IEmployeeEmployeeRoleRepository, IEmployerEmployeeRoleRepository, IPlatformEmployeeRoleRepository
    {
        public EmployeeRoleRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
    public interface IHRBusinessPartRepository : IEntityDataRepository<HRBusinessPart>
    {
    }

    public class HRBusinessPartRepository : EntityDataRepository<HRBusinessPart>, IHRBusinessPartRepository, IEmployeeHRBusinessPartRepository, IEmployerHRBusinessPartRepository, IPlatformHRBusinessPartRepository
    {
        public HRBusinessPartRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
}