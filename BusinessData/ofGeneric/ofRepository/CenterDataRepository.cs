using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessData
{
    public interface ICenterDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Center, IRelationable
    {
        // By
        Task<TEntity> GetByLoginId(string LoginId);
        Task<TEntity> GetByAddress(string Address);
        Task<List<TEntity>> GetToListByCountryCode(string CoutryCode);
        // With
        Task<List<TEntity>> GetToListWithCommodities();
        Task<List<TEntity>> GetToListWithEStatuses();
        Task<List<TEntity>> GetToListWithMStatuses();
        Task<List<TEntity>> GetToListWithSStatuses();
        Task<List<TEntity>> GetToListWithCenterMacAddresses();
        Task<List<TEntity>> GetToListWithCenterIPAddresses();
        Task<List<TEntity>> GetToListWithCenterRoles();
        // By With
        Task<List<TEntity>> GetToListByCountryCodeWithRelated(string CoutryCode);
        Task<TEntity> GetByCenterWithStatus(TEntity entity);
    }
    public class CenterDataRepository<TEntity> : EntityDataRepository<TEntity>, 
                                                    ICenterDataRepository<TEntity>
                                                where TEntity : Center, IRelationable, new()
    {
        public CenterDataRepository(DbContext DbContext)
            : base(DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(), entity.GetDbConnetionString()); }
        }
        public CenterDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(), entity.GetDbConnetionString());
        }
        public async Task<TEntity> GetByAddress(string Address)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.Address.Equals(Address));
        }
        public async Task<TEntity> GetByLoginId(string LoginId)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.LoginId.Equals(LoginId));
        }

        public async Task<List<TEntity>> GetToListByCountryCode(string CoutryCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CountryCode.Equals(CoutryCode)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCountryCodeWithRelated(string CoutryCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CountryCode.Equals(CoutryCode)).Include(entity => entity.ChangedUsers).
                                                                                        Include(entity => entity.Docs).
                                                                                        Include(entity => entity.ImageofInfos).
                                                                                        Include(entity => entity.SStatuses).
                                                                                        Include(entity => entity.MStatuses).
                                                                                        Include(entity => entity.EStatuses).
                                                                                        Include(entity => entity.Commodities).
                                                                                        Include(entity => entity.CenterIPAddresses).
                                                                                        Include(entity => entity.CenterMacAddresses).
                                                                                        Include(entity => entity.CenterRoles).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCenterIPAddresses()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.CenterIPAddresses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCenterMacAddresses()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.CenterMacAddresses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCenterRoles()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.CenterRoles).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCommodities()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.Commodities).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithEStatuses()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithMStatuses()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.MStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithSStatuses()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.SStatuses).ToListAsync();
        }

        public async Task<bool> IsDuplecatedByNameAsync(TEntity tentity)
        {
            Center center = await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.Name.Equals(tentity.Name));
            if(center == null)
            {
                return true;
            }
            return false;
        }
        public async Task<TEntity> GetByCenterWithStatus(TEntity entity)
        {
            return await _DbContext.Set<TEntity>().Include(e => e.SStatuses).Include(e => e.MStatuses).Include(e => e.MStatuses).
                Include(e => e.Commodities).FirstOrDefaultAsync(e=>e.Equals(entity));
        }
    }
}