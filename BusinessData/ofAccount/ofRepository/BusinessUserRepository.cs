using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using BusinessData.ofAccount.ofModel;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofAccount.ofRepository
{
    public interface IBusinessUserRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Entity, IRelationable, new()
    {
    }
    public class BusinessUserRepository : EntityDataRepository<BusinessUser>, IBusinessUserRepository<BusinessUser>
    {
        private readonly BusinessUserDbContext _BusinessUserDbContext;
        public BusinessUserRepository(BusinessUserDbContext BusinessUserDbContext)
        {
            _BusinessUserDbContext = BusinessUserDbContext;
        }
        public async Task<BusinessUser> GetByUserIdWithTableSetting(string UserId)
        {
            return await _DbContext.Set<BusinessUser>().Where(e => e.UserId.Equals(UserId)).Include(e => e.TableSettings).FirstOrDefaultAsync();
        }
    }
    public interface IBusinessUserRepository : IEntityDataRepository<BusinessUser>
    {

    }
    public interface ITableSettingRepository
    {

    }
    public interface IJournalSettingRepository
    {

    }
    public interface IPayServiceRepository
    {

    }
    // public class UserTableSettingRepository : AccountDataRepository<UserTableSetting>
    // {
    //     public UserTableSettingRepository(BusinessUserDbContext BusinessUserDbContext)
    //         : base(BusinessUserDbContext)
    //     {
    //     }
    // }
}