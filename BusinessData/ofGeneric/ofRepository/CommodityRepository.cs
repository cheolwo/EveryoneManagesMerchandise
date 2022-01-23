using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusinessData.ofGenericRepository
{
    public interface ICommodityDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Commodity, IRelationable, new()
    {
        //By
        Task<List<TEntity>> GetToListByHsCode(string HsCode);
        Task<TEntity> GetByBarcodeAsync(string Barcode);
        Task<List<TEntity>> GetToListByCenterAsync(Center Center);
        
        //With
        Task<List<TEntity>> GetToListWithEStatuses();
        Task<List<TEntity>> GetToListWithMStatuses();
        Task<List<TEntity>> GetToListWithSStatuses();

        // By With
        Task<List<TEntity>> GetToListByCenterWithEStatues(Center Center);
        Task<List<TEntity>> GetToListByCenterWithMStatues(Center Center);
        Task<List<TEntity>> GetToListByCenterWithSStatues(Center Center);
        Task<List<TEntity>> GetToListByCenterWithRelatedStatuses(Center Center);

        Task<List<TEntity>> GetToListByHsCodeWithEStatues(string HsCode);
        Task<List<TEntity>> GetToListByHsCodeWithMStatues(string HsCode);
        Task<List<TEntity>> GetToListByHsCodeWithSStatues(string HsCode);
        Task<List<TEntity>> GetToListByHsCodeWithRelatedStatuses(string HsCode);

        Task<List<TEntity>> GetToListByBarcodeWithEStatues(string Barcode);
        Task<List<TEntity>> GetToListByBarcodeWithMStatues(string Barcode);
        Task<List<TEntity>> GetToListByBarcodeWithSStatues(string Barcode);
        Task<List<TEntity>> GetToListByBarcodeWithRelatedStatuses(string Barcode);
    }
    public class CommodityDataRepository<TEntity> : EntityDataRepository<TEntity>, ICommodityDataRepository<TEntity>
                                                     where TEntity : Commodity, IRelationable, new()
    {
        public CommodityDataRepository(DbContext DbContext)
            :base(DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(), entity.GetDbConnetionString()); }
        }
        public CommodityDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(), entity.GetDbConnetionString());
        }
        
        public async Task<TEntity> GetByBarcodeAsync(string Barcode)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.Barcode.Equals(Barcode));
        }

        public async Task<List<TEntity>> GetToListByBarcodeWithEStatues(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(entity => entity.EStatuses).
                                                                                                                        ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByBarcodeWithMStatues(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(entity => entity.MStatuses).
                                                                                                                        ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByBarcodeWithSStatues(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(entity => entity.SStatuses).
                                                                                                                        ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByBarcodeWithRelatedStatuses(string Barcode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Barcode.Equals(Barcode)).Include(entity => entity.EStatuses).
                                                                                        Include(entity => entity.MStatuses).
                                                                                        Include(entity => entity.SStatuses).
                                                                                        ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByCenterAsync(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterWithEStatues(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCenterWithMStatues(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).Include(entity => entity.MStatuses).ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByCenterWithSStatues(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).Include(entity => entity.SStatuses).ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByCenterWithRelatedStatuses(Center Center)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Center.Equals(Center)).Include(entity => entity.SStatuses).
                                                                                        Include(entity => entity.MStatuses).
                                                                                        Include(entity => entity.EStatuses).
                                                                                        ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCode(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithEStatues(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithMStatues(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(entity => entity.MStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithRelatedStatuses(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(entity => entity.EStatuses).
                                                                                            Include(entity => entity.MStatuses).
                                                                                            Include(entity => entity.SStatuses).
                                                                                            ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByHsCodeWithSStatues(string HsCode)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.HsCode.Equals(HsCode)).Include(entity => entity.SStatuses).ToListAsync();
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

        public async Task<bool> IsDuplecatedByNameAsync(TEntity entity)
        {
            TEntity FindEntity = await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.Name.Equals(entity.Name));
            if (FindEntity != null) { return true;  }
            else { return false;  }
        }
    }
}