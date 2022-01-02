using BusinessData.ofAccount.ofRepository;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofAccount.ofModel
{

    public interface IBusinessEmloyeeRepository : IEntityDataRepository<BusinessEmployee>
    {

    }
    public class BusinessEmployeeRepository : EntityDataRepository<BusinessEmployee>, IBusinessEmloyeeRepository
    {
        public BusinessEmployeeRepository(BusinessEmployeeDbContext BusinessUserDbContext)
            : base(BusinessUserDbContext)
        {
        }
    }
}
