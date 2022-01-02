using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using BusinessData.ofAccount.ofModel;

namespace BusinessData.ofAccount.ofRepository
{
    public interface IEmployeeUserRepository<TEntity> where TEntity : EmployeeAccountEntity
    {
        Task<List<TEntity>> GetToListAsync();
        Task<TEntity> AddAsync(TEntity tentity);
        Task<TEntity> Update(TEntity tentity);
        void DeleteByEntity(TEntity tentity);
    }
    public class EmployeeUserRepository<TEntity> : IEmployeeUserRepository<TEntity> where TEntity : EmployeeAccountEntity
    {
        private readonly EmployeeUserDbContext _EmployeeUserDbContext;
        public EmployeeUserRepository(EmployeeUserDbContext EmployeeUserDbContext)
        {
            _EmployeeUserDbContext = EmployeeUserDbContext;
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
    }
    public interface IEmployeeUserRepository
    {

    }
    public class EmployeeUserRepository : EmployeeUserRepository<EmployeeUser>, IEmployeeUserRepository
    {
        public EmployeeUserRepository(EmployeeUserDbContext EmployeeUserDbContext)
            : base(EmployeeUserDbContext)
        {
        }
    }
}