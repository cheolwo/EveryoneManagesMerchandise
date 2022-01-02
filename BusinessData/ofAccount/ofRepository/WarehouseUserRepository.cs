using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using BusinessData.ofAccount.ofModel;

namespace BusinessData.ofAccount.ofRepository
{
    public interface IWarehouseUserRepository<TEntity> : IBusinessUserRepository<TEntity> where TEntity : BusinessUser
    {
    }
    public class WarehouseUserRepository<TEntity> : IWarehouseUserRepository<TEntity> where TEntity : BusinessUser
    {
        private readonly BusinessUserDbContext _BusinessUserDbContext;
        public WarehouseUserRepository(BusinessUserDbContext BusinessUserDbContext)
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

        public Task<TEntity> Update(TEntity tentity)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity tentity)
        {
            throw new NotImplementedException();
        }
    }
}