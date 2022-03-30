using System.Threading.Tasks;
using BusinessData.ofGenericRepository;
using BusinessData.ofGroupOrder.ofDbContext;
using BusinessData.ofGroupOrder.ofInterface.ofEmployee;
using BusinessData.ofGroupOrder.ofInterface.ofEmployer;
using BusinessData.ofGroupOrder.ofInterface.ofPlatform;
using BusinessData.ofGroupOrder.ofModel;

namespace BusinessData.ofGO.ofRepository
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
        public GOCRepository(GODbContext GODbContext)
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
        public GOCCRepository(GODbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class SGOCRepository : StatusDataRepository<SGOC>, ISGOCRepository, IEmployeeSGOCRepository, IEmployerSGOCRepository, IPlatformSGOCRepository
    {
        public SGOCRepository(GODbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class MGOCRepository : StatusDataRepository<MGOC>, IMGOCRepository, IEmployeeMGOCRepository, IEmployerMGOCRepository, IPlatformMGOCRepository
    {
        public MGOCRepository(GODbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class EGOCRepository : StatusDataRepository<EGOC>, IEGOCRepository, IEmployeeEGOCRepository, IEmployerEGOCRepository, IPlatformEGOCRepository
    {
        public EGOCRepository(GODbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
}
