using System.Threading.Tasks;
using BusinessData.ofGenericRepository;
using BusinessData.ofGroupOrder.ofDbContext;
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
    public class GOCRepository : CenterDataRepository<GOC>, IGOCRepository
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
    public class GOCCRepository : CommodityDataRepository<GOCC>, IGOCCRepository
    {
        public GOCCRepository(GODbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class SGOCRepository : StatusDataRepository<SGOC>, ISGOCRepository
    {
        public SGOCRepository(GODbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class MGOCRepository : StatusDataRepository<MGOC>, IMGOCRepository
    {
        public MGOCRepository(GODbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
    public class EGOCRepository : StatusDataRepository<EGOC>, IEGOCRepository
    {
        public EGOCRepository(GODbContext GODbContext)
            :base(GODbContext)
        {

        }
    }
}
