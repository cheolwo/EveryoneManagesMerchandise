using BusinessData.ofHR.ofDbContext;
using BusinessData.ofHumanResouce.ofIdFactory;
using BusinessData.ofHumanResource.ofRepository;

namespace BusinessData.ofHRCenter.ofRepository
{
    public interface IHRCenterRepository : ICenterDataRepository<HRCenter>
    {
    }

    public class HRCenterRepository : CenterDataRepository<HRCenter>, IHRCenterRepository
    {
        public HRCenterRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
    public interface IHREmployeeRepository : IEntityDataRepository<HREmployee>
    {
    }

    public class HREmployeeRepository : EntityDataRepository<HREmployee>, IHREmployeeRepository
    {
        public HREmployeeRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
    public interface IHRRoleRepository : IEntityDataRepository<HRRole>
    {
    }

    public class HRRoleRepository : EntityDataRepository<HRRole>, IHRRoleRepository
    {
        public HRRoleRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
    public interface IEmployeeRoleRepository : IEntityDataRepository<EmployeeRole>
    {
    }

    public class EmployeeRoleRepository : EntityDataRepository<EmployeeRole>, IEmployeeRoleRepository
    {
        public EmployeeRoleRepository(HRDbContext HRDbContext)
            :base(HRDbContext)
        {
        }
    }
}