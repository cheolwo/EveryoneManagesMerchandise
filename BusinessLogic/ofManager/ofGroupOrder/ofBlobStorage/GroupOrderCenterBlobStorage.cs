using BusinessData.ofGO.ofRepository;
using BusinessData.ofGroupOrder.ofModel;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofGroupOrder.ofBlobStorage
{
    public interface IGOCCBlobContainerFactory : IEntityContainerFactory<GOCC>
    {

    }
    public interface ISGOCBlobContainerFactory : IEntityContainerFactory<SGOC>
    {

    }
    public interface IMGOCBlobContainerFactory : IEntityContainerFactory<MGOC>
    {

    }
    public interface IEGOCBlobContainerFactory : IEntityContainerFactory<EGOC>
    {

    }
    public interface IGOCBlobContainerFactory : IEntityContainerFactory<GOC>
    {

    }
    public class GOCBlobContainerFactory : EntityContainerFactory<GOC>, IGOCBlobContainerFactory
    {
        private readonly IGOCRepository _GOCRepository;
        public GOCBlobContainerFactory(IGOCRepository GOCRepository)
                :base(GOCRepository)
        {
            _GOCRepository = GOCRepository;
        }
        public override async Task<string> CreateNameofContainer(GOC entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IGOCCBlobStorage : IEntityBlobStorage<GOCC>
    {

    }
    public interface ISGOCBlobStorage : IEntityBlobStorage<SGOC>
    {

    }
    public interface IMGOCBlobStorage : IEntityBlobStorage<MGOC>
    {

    }
    public interface IEGOCBlobStorage : IEntityBlobStorage<EGOC>
    {

    }
    public interface IGOCBlobStorage : IEntityBlobStorage<GOC>
    {

    }
    public class GOCBlobStorage : EntityBlobStorage<GOC>, IGOCBlobStorage
    {
        public GOCBlobStorage(IGOCBlobContainerFactory GOCBlobContainerFactory)
            : base(GOCBlobContainerFactory)
        {

        }
    }
    public class SGOCBlobStorage : EntityBlobStorage<SGOC>, ISGOCBlobStorage
    {
        public SGOCBlobStorage(ISGOCBlobContainerFactory SGOCBlobContainerFactory)
            : base(SGOCBlobContainerFactory)
        {

        }

    }
    public class MGOCBlobStorage : EntityBlobStorage<MGOC>, IMGOCBlobStorage
    {
        public MGOCBlobStorage(IMGOCBlobContainerFactory MGOCBlobContainerFactory)
            : base(MGOCBlobContainerFactory)
        {

        }
    }
    public class EGOCBlobStorage : EntityBlobStorage<EGOC>, IEGOCBlobStorage
    {
        public EGOCBlobStorage(IEGOCBlobContainerFactory EGOCBlobContainerFactory)
            : base(EGOCBlobContainerFactory)
        {

        }
    }
    public class GOCCBlobStorage : EntityBlobStorage<GOCC>, IGOCCBlobStorage
    {
        public GOCCBlobStorage(IGOCCBlobContainerFactory GOCCBlobContainerFactory)
            : base(GOCCBlobContainerFactory)
        {

        }
    }
}