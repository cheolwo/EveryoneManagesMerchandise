using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessData
{
    public interface IStatusDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Status
    {
        // Get By
        Task<TEntity> GetByCommodityIdAsync(string CommodityId);
        Task<TEntity> GetByCenterIdAsync(string CenterId);
        
        // GetToList By
        Task<List<TEntity>> GetToListByCommodityIdAsync(string CommodityId);
        Task<List<TEntity>> GetToListByCenterIdAsync(string CenterId);
        Task<List<TEntity>> GetToListByQuantityAsync(int MaxQuantity);
        Task<List<TEntity>> GetToListByQuntityAsync(int MinQuantity, int MaxQuantity);

        // Get By With
        Task<TEntity> GetByCommodityIdWithRelatedAsync(string CommodityId);
        Task<TEntity> GetByCenterIdWithRelatedAsync(string CenterId);
        // Get To List By With
        Task<List<TEntity>> GetToListByCommodityIdWithRelatedAsync(string CommodityId);
        Task<List<TEntity>> GetToListByCenterIdWithRelatedAsync(string CenterId);
        Task<List<TEntity>> GetToListByQuantityWithRelatedAsync(int MaxQuantity);
        Task<List<TEntity>> GetToListByQuntityWithRelatedAsync(int MinQuantity, int MaxQuantity);

        // List
        Task<List<TEntity>> GetToListWithCenterAsync();
        Task<List<TEntity>> GetToListWithCommodity();
    }
    public class StatusDataRepository<TEntity> : EntityDataRepository<TEntity>, IStatusDataRepository<TEntity> where TEntity : Status, new()
    {
        public StatusDataRepository(DbContext DbContext)
            :base(DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity))); }
        }
        public StatusDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity)));
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

        public async Task<List<TEntity>> GetToListWithCommodityAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.Commodity).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCommodityIdAsync(string CommodityId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CommodityId.Equals(CommodityId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterIdAsync(string CenterId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CenterId.Equals(CenterId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByQuantityAsync(int MaxQuantity)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Quantity <= MaxQuantity).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByQuntityAsync(int MinQuantity, int MaxQuantity)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Quantity >= MinQuantity && e.Quantity <= MaxQuantity).ToListAsync();
        }

        Task<TEntity> IStatusDataRepository<TEntity>.GetByCommodityIdAsync(string CommodityId)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IStatusDataRepository<TEntity>.GetByCenterIdAsync(string CenterId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListByCommodityIdAsync(string CommodityId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListByCenterIdAsync(string CenterId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListByQuantityAsync(int MaxQuantity)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListByQuntityAsync(int MinQuantity, int MaxQuantity)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IStatusDataRepository<TEntity>.GetByCommodityIdWithRelatedAsync(string CommodityId)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IStatusDataRepository<TEntity>.GetByCenterIdWithRelatedAsync(string CenterId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListByCommodityIdWithRelatedAsync(string CommodityId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListByCenterIdWithRelatedAsync(string CenterId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListByQuantityWithRelatedAsync(int MaxQuantity)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListByQuntityWithRelatedAsync(int MinQuantity, int MaxQuantity)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListWithCenterAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IStatusDataRepository<TEntity>.GetToListWithCommodity()
        {
            throw new NotImplementedException();
        }
    }
    public interface ISStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : SStatus, IRelationable, new()
    {
        Task<List<TEntity>> GetToListWithMStatusesAsync();
    }
    public class SStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, ISStatusDataRepository<TEntity> where TEntity : SStatus, IRelationable, new()
    {
        public SStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }
        public async Task<List<TEntity>> GetToListWithMStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.MStatuses).ToListAsync();
        }
    }
    public interface IMStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : MStatus, IRelationable, new()
    {
        Task<List<TEntity>> GetToListWithEStatusesAsync();
        Task<List<TEntity>> GetToListWithSStatusAsync();
    }
    public class MStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, IMStatusDataRepository<TEntity> where TEntity : MStatus, IRelationable, new()
    {
        public MStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }

        public async Task<List<TEntity>> GetToListWithEStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithSStatusAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.SStatus).ToListAsync();
        }
    }
    public interface IEStatusDataRepository<TEntity> : IStatusDataRepository<TEntity> where TEntity : EStatus, IRelationable, new()
    {
        Task<List<TEntity>> GetToListWithMStatusAsync();
    }
    public class EStatusDataRepository<TEntity> : StatusDataRepository<TEntity>, IEStatusDataRepository<TEntity> where TEntity : EStatus, IRelationable, new()
    {
        public EStatusDataRepository(DbContext DbContext) : base(DbContext)
        {
        }

        public Task<List<TEntity>> GetToListWithMStatusAsync()
        {
            throw new NotImplementedException();
        }
    }
}