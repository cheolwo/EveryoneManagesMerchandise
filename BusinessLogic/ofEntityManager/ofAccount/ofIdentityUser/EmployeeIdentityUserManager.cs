using BusinessData.ofAccount.ofModel.ofIdentity;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofAccount.ofIdentityUser
{
    public class EmployeeIdentityUserManager : UserManager<EmployeeIdentityUser>
    {
        public EmployeeIdentityUserManager(IUserStore<EmployeeIdentityUser> store, IOptions<IdentityOptions> optionsAccessor,
            IPasswordHasher<EmployeeIdentityUser> passwordHasher, IEnumerable<IUserValidator<EmployeeIdentityUser>> userValidators,
            IEnumerable<IPasswordValidator<EmployeeIdentityUser>> passwordValidators, ILookupNormalizer keyNormalizer,
            IdentityErrorDescriber errors, IServiceProvider services, ILogger<UserManager<EmployeeIdentityUser>> logger)
            :base(store,optionsAccessor,passwordHasher,userValidators,passwordValidators,keyNormalizer,errors,services,logger)
        {
            
        }
    }
}
