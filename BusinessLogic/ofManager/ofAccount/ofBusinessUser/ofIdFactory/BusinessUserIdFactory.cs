using BusinessData.ofAccount.ofModel;
using BusinessData.ofAccount.ofRepository;
using BusinessData.ofGeneric.ofIdFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofAccount.ofBusinessUser.ofIdFactory
{
    public interface IBusinessUserIdFactory : IEntityIdFactory<BusinessUser>
    {
        
    }
    public class BusinessUserIdFactory : EntityIdFactory<BusinessUser>, IBusinessUserIdFactory
    {
        public BusinessUserIdFactory(IBusinessUserRepository BusinessUserRepository)
            : base(BusinessUserRepository)
        {

        }
    }
}
