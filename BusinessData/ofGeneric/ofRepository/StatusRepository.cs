using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessData
{
    public interface IStatusDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Status, IRelationable
    {
        Task<List<TEntity>> GetToListByCountryCodeAsync(string CountryCode);
        // List
        Task<List<TEntity>> GetToListWithCenterAsync();
        Task<List<TEntity>> GetToListWithCommodity();
    }
    public class StatusDataRepository<TEntity> : EntityDataRepository<TEntity>, IStatusDataRepository<TEntity> where TEntity : Status, IRelationable, new()
    {
        public StatusDataRepository(DbContext DbContext)
            :base(DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(), entity.GetDbConnetionString()); }
        }
        public StatusDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(), entity.GetDbConnetionString());
        }
        public async Task<List<TEntity>> GetToListByCountryCode(string CountryCode)
        {
            List<TEntity> TEntityes = await GetToListWithCenterAsync();
            TEntityes = TEntityes.Where(e => e.Center.CountryCode.Equals(CountryCode)).ToList();
            return TEntityes;
        }

        public Task<List<TEntity>> GetToListByCountryCodeAsync(string CountryCode)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TEntity>> GetToListWithCenterAsync()
        {
            return await _DbContext.Set<TEntity>().Include(TEntity => TEntity.Center).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCommodity()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.Commodity).ToListAsync();
        }
    }
    public interface ISStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : SStatus, IRelationable, new()
    {
        Task<List<TEntity>> GetToListWithMStatuses();
    }
    public class SStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, ISStatusDataRepository<TEntity> where TEntity : SStatus, IRelationable, new()
    {
        public SStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }
        public async Task<List<TEntity>> GetToListWithMStatuses()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.MStatuses).ToListAsync();
        }
    }
    public interface IMStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : MStatus, IRelationable, new()
    {
        Task<List<TEntity>> GetToListWithEStatuses();
        Task<List<TEntity>> GetToListWithSStatus();
    }
    public class MStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, IMStatusDataRepository<TEntity> where TEntity : MStatus, IRelationable, new()
    {
        public MStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }

        public async Task<List<TEntity>> GetToListWithEStatuses()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithSStatus()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.SStatus).ToListAsync();
        }
    }
    public interface IEStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : EStatus, IRelationable, new()
    {
        Task<List<TEntity>> GetToListWithMStatus();
    }
    public class EStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, IEStatusDataRepository<TEntity> where TEntity : EStatus, IRelationable, new()
    {
        public EStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }

        public Task<List<TEntity>> GetToListWithMStatus()
        {
            throw new NotImplementedException();
        }
    }
}