using BusinessData.ofAccount.ofModel;
using BusinessData.ofAccount.ofRepository;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofAccount.ofBusinessUser.ofBlobStorage
{
    public interface IBusinessUserBlobContainerFactory : IEntityContainerFactory<BusinessUser>
    {

    }
    public class BusinessUserBlobContainerFactory : EntityContainerFactory<BusinessUser>, IBusinessUserBlobContainerFactory
    {
        public BusinessUserBlobContainerFactory(IBusinessUserRepository BusinessUserRepository)
                :base(BusinessUserRepository)
        {
            
        }
        public override async Task<string> CreateNameofContainer(BusinessUser entity)
        {
            return await base.CreateNameofContainer(entity);
        }
    }
    public interface IBusinessUserBlobStorage : IEntityBlobStorage<BusinessUser>
    {

    }
    public class BusinessUserBlobStorage : EntityBlobStorage<BusinessUser>, IBusinessUserBlobStorage
    {
        public BusinessUserBlobStorage(IBusinessUserBlobContainerFactory BusinessUserBlobContainerFactory)
            : base(BusinessUserBlobContainerFactory)
        {

        }
    }
}
