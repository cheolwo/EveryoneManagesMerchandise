    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System;
    using BusinessData.ofAccount.ofModel;

    namespace BusinessData.ofAccount.ofRepository
    {
    public interface IBusinessUserRepository<TEntity> where TEntity : BusinessAccountEntity
    {
        Task<List<TEntity>> GetToListAsync();
        Task<TEntity> AddAsync(TEntity tentity);
        Task<TEntity> UpdateAsync(TEntity tentity);
        void DeleteByEntity(TEntity tentity);
    }
    public class BusinessUserRepository<TEntity> : IBusinessUserRepository<TEntity> where TEntity : BusinessAccountEntity
    {
        private readonly BusinessUserDbContext _BusinessUserDbContext;
        public BusinessUserRepository(BusinessUserDbContext BusinessUserDbContext)
        {
            _BusinessUserDbContext = BusinessUserDbContext;
        }

        public Task<TEntity> AddAsync(TEntity tentity)
        {
            throw new NotImplementedException();
        }

        public void DeleteByEntity(TEntity tentity)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetToListAsync()
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity tentity)
        {
            throw new NotImplementedException();
        }
    }
    public interface IBusinessUserRepository
    {

    }
    public class BusinessUserRepository : BusinessUserRepository<BusinessUser>, IBusinessUserRepository
    {
        public BusinessUserRepository(BusinessUserDbContext BusinessUserDbContext)
            : base(BusinessUserDbContext)
        {
        }
    }
    public interface IWarehouseUserRepository
    {

    }
    public class WarehouseUserRepository : BusinessUserRepository<WarehouseUser>, IWarehouseUserRepository
    {
        public WarehouseUserRepository(BusinessUserDbContext WarehouseUserDbContext)
            : base(WarehouseUserDbContext)
        {
        }
    }
    
    public interface ITableSettingRepository
    {

    }
    public class TableSettingRepository : BusinessUserRepository<TableSetting>, ITableSettingRepository
    {
        public TableSettingRepository(BusinessUserDbContext BusinessUserDbContext)
            : base(BusinessUserDbContext)
        {
        }
    }
    public interface IJournalSettingRepository
    {

    }
    public class JournalSettingRepository : BusinessUserRepository<JournalSetting>, IJournalSettingRepository
    {
        public JournalSettingRepository(BusinessUserDbContext BusinessUserDbContext)
            : base(BusinessUserDbContext)
        {
        }
    }
    public interface IPayServiceRepository
    {

    }
    public class PayServiceRepository : BusinessUserRepository<PayService>, IPayServiceRepository
    {
        public PayServiceRepository(BusinessUserDbContext BusinessUserDbContext)
            : base(BusinessUserDbContext)
        {
        }
    }
    // public class UserTableSettingRepository : AccountDataRepository<UserTableSetting>
    // {
    //     public UserTableSettingRepository(BusinessUserDbContext BusinessUserDbContext)
    //         : base(BusinessUserDbContext)
    //     {
    //     }
    // }
}