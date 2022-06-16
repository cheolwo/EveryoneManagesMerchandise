using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofDbContext;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofInterface.ofEmployee;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofInterface.ofEmployer;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofInterface.ofPlatform;
using BusinessData.ofDataAccessLayer.ofGroupOrder.ofModel;

namespace BusinessData.ofDataAccessLayer.ofGroupOrder.ofRepository
{
    public interface IGOCRepository : ICenterDataRepository<GOC>
    {
        Task<GOC> GetRelatedData(GOC GOC);
    }
    public interface IGOCCRepository : ICommodityDataRepository<GOCC>
    {

    }
    public interface ISGOCRepository : IStatusDataRepository<SGOC>
    {

    }
    public interface IMGOCRepository : IStatusDataRepository<MGOC>
    {

    }
    public interface IEGOCRepository : IStatusDataRepository<EGOC>
    {

    }
    public class GOCRepository : CenterDataRepository<GOC>, IGOCRepository, IEmployeeGOCRepository, IEmployerGOCRepository, IPlatformGOCRepository
    {
        public GOCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }

        public Task<GOC> GetRelatedData(GOC GOC)
        {
            throw new System.NotImplementedException();
        }
    }
    public class GOCCRepository : CommodityDataRepository<GOCC>, IGOCCRepository, IEmployeeGOCCRepository, IEmployerGOCCRepository, IPlatformGOCCRepository
    {
        public GOCCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class SGOCRepository : StatusDataRepository<SGOC>, ISGOCRepository, IEmployeeSGOCRepository, IEmployerSGOCRepository, IPlatformSGOCRepository
    {
        public SGOCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class MGOCRepository : StatusDataRepository<MGOC>, IMGOCRepository, IEmployeeMGOCRepository, IEmployerMGOCRepository, IPlatformMGOCRepository
    {
        public MGOCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class EGOCRepository : StatusDataRepository<EGOC>, IEGOCRepository, IEmployeeEGOCRepository, IEmployerEGOCRepository, IPlatformEGOCRepository
    {
        public EGOCRepository(GroupOrderDbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
}
