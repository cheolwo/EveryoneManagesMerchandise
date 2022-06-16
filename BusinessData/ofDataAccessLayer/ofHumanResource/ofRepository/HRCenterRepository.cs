using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofHR.ofDbContext;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofInterface.ofEmployee;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofInterface.ofEmployer;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofInterface.ofPlatform;
using BusinessData.ofDataAccessLayer.ofHumanResource.ofModel;
using System;

namespace BusinessData.ofDataAccessLayer.ofHRCenter.ofRepository
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
        public HRCenterRepository(Action<RepositoryOptions> options)
            : base(options)
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
        public HREmployeeRepository(Action<RepositoryOptions> options)
            : base(options)
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
        public HRRoleRepository(Action<RepositoryOptions> options)
            : base(options)
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
        public EmployeeRoleRepository(Action<RepositoryOptions> options)
            : base(options)
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
        public HRBusinessPartRepository(Action<RepositoryOptions> options)
            : base(options)
        {

        }
    }
}