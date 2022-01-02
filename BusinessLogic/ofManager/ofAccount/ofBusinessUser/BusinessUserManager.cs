using BusinessData.ofAccount.ofModel;
using BusinessData.ofAccount.ofRepository;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofManager
{
    public interface IBusinessUserManager<TEntity> where TEntity : BusinessUser
    {
        Task<List<TEntity>> GetToListAsync();
        Task<TEntity> AddAsync(TEntity tentity);
        Task<TEntity> UpdateAsync(TEntity tentity);
        Task<TEntity> GetUserByIdentityUser(IdentityUser identityUser);
        void DeleteByEntity(TEntity tentity);
    }
    public class BusinessUserManager<TEntity> : IBusinessUserManager<TEntity> where TEntity : BusinessUser
    {
        private readonly IBusinessUserRepository<TEntity> _BusinessUserRepository;
        public BusinessUserManager(IBusinessUserRepository<TEntity> BusinessUserRepository)
        {
            _BusinessUserRepository = BusinessUserRepository;
        }

        public Task<TEntity> AddAsync(TEntity tentity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteByEntity(TEntity tentity)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<TEntity>> GetToListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> GetUserByIdentityUser(IdentityUser identityUser)
        {
            throw new System.NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity tentity)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IBusinessUserManager : IBusinessUserManager<BusinessUser>
    {

    }
    public class BusinessUserManager : IBusinessUserManager
    {
        private readonly IBusinessUserRepository _businessUserRepository;
        public BusinessUserManager(IBusinessUserRepository businessUserRepository)
        {
            _businessUserRepository = businessUserRepository;
        }
        public Task<BusinessUser> AddAsync(BusinessUser tentity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteByEntity(BusinessUser tentity)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<BusinessUser>> GetToListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<BusinessUser> GetUserByIdentityUser(IdentityUser identityUser)
        {
            throw new System.NotImplementedException();
        }

        public Task<BusinessUser> UpdateAsync(BusinessUser tentity)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface IWarehouseUserManager<TEntity> : IBusinessUserManager<TEntity> where TEntity : WarehouseUser
    {

    }

    public class WarehouseUserManager<TEntity> : BusinessUserManager<TEntity>, IWarehouseUserManager<TEntity> where TEntity : WarehouseUser
    {
        private readonly IWarehouseUserRepository<TEntity> _WarehouseUserRepository;
        public WarehouseUserManager(IWarehouseUserRepository<TEntity> WarehouseUserRepository)
                         : base(WarehouseUserRepository)
        {
            _WarehouseUserRepository = WarehouseUserRepository;
        }
    }

    public class WarehouseUserManager
    {
        private readonly IWarehouseUserRepository _warehouseUserRepository;
        public WarehouseUserManager(IWarehouseUserRepository warehouseUserRepository)
        {
            _warehouseUserRepository = warehouseUserRepository;
        }

        public Task<WarehouseUser> AddAsync(WarehouseUser tentity)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteByEntity(WarehouseUser tentity)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<WarehouseUser>> GetToListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<WarehouseUser> UpdateAsync(WarehouseUser tentity)
        {
            throw new System.NotImplementedException();
        }
    }
}

/* Role Seed Logic*/
// private enum Role { Producter, Consumer, OnlineSelle, Logister, TradionSeller }

//         public async Task InitRole()
//         {
//             foreach (Role Role in Enum.GetValues(typeof(Role)))
//             {
//                 IdentityRole identityRole = new IdentityRole(Role.ToString());
//                 BusinessRole newRole = await _roleManager.FindByNameAsync(Role.ToString());
//                 if (newRole is null)
//                 {
//                     await _roleManager.CreateAsync(newRole);
//                 }
//             }
//         }
//         public async Task RegisteRoletoTraditionalSeller(string UserId)
//         {
//             BusinessUser user = await _userManager.GetUserAsync(_httpContextAccessor.HttpContext.User);
//             if (user != null)
//             {
//                 var Result = await _userManager.AddToRoleAsync(user, Role.TradionSeller.ToString());

//                 if (Result.Succeeded)
//                 {
//                     return;
//                 }
//                 else
//                 {
//                     throw new ArgumentException("Failed Register Role");
//                 }
//             }
//         }
//         public async Task RegisteRoletoTraditionalSeller(BusinessUser user)
//         {
//             if (user != null)
//             {
//                 var Result = await _userManager.AddToRoleAsync(user, Role.TradionSeller.ToString());

//                 if (Result.Succeeded)
//                 {
//                     return;
//                 }
//                 else
//                 {
//                     throw new ArgumentException("Failed Register Role");
//                 }
//             }
//         }
