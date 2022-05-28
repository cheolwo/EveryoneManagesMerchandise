using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BusinessData
{
    public interface ICenterDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Center
    {
        // Get By
        Task<TEntity> GetByIdAsync(string id);
        Task<TEntity> GetByLoginIdAsync(string LoginId);
        Task<TEntity> GetByAddressAsync(string Address);
        Task<TEntity> GetByCountryCodeAsync(string CountryCode);
        Task<TEntity> GetByPhoneNumberAsync(string PhoneNumber);
        Task<TEntity> GetByFaxnumberAsync(string Faxnumber);

        // Get To List By
        Task<List<TEntity>> GetToListByLoginIdAsync(string LoginId);
        Task<List<TEntity>> GetToListByAddressAsync(string Address);
        Task<List<TEntity>> GetToListByCountryCodeAsync(string CoutryCode);
        Task<List<TEntity>> GetToListByPhoneNumberAsync(string PhoneNumber);
        Task<List<TEntity>> GetToListByFaxnNumberAsync(string FaxNumber);

        // GetByWithRelated
        Task<TEntity> GetByIdWithRelatedAsync(string id);
        Task<TEntity> GetByLoginIdWithRelatedAsync(string LoginId);
        Task<TEntity> GetByAddressWithRelatedAsync(string Address);
        Task<TEntity> GetByCountryCodeWithRelatedAsync(string CountryCode);
        Task<TEntity> GetByPhoneNumberWithRelatedAsync(string PhoneNumber);
        Task<TEntity> GetByFaxnumberWithRelatedAsync(string Faxnumber);
        
        // GetToListByWithRelated
        Task<List<TEntity>> GetToListByCountryCodeWithRelatedAsync(string CoutryCode);
        Task<List<TEntity>> GetToListByUserIdWithRelatedAsync(string userId);
        Task<List<TEntity>> GetToListByAddressWithRelatedAsync(string Address);
        Task<List<TEntity>> GetToListByPhoneNumberWithRelatedAsync(string PhoneNumber);
        Task<List<TEntity>> GetToListByFaxNumberWithRelatedAsync(string FaxNumber);
        // With
        Task<List<TEntity>> GetToListWithCommoditiesAsync();
        Task<List<TEntity>> GetToListWithEStatusesAsync();
        Task<List<TEntity>> GetToListWithMStatusesAsync();
        Task<List<TEntity>> GetToListWithSStatusesAsync();
        Task<List<TEntity>> GetToListWithStatusesAsync();
        Task<List<TEntity>> GetToListWithCenterMacAddressesAsync();
        Task<List<TEntity>> GetToListWithCenterIPAddressesAsync();
        Task<List<TEntity>> GetToListWithCenterRolesAsync();
        
    }
    public class CenterDataRepository<TEntity> : EntityDataRepository<TEntity>,
                                                    ICenterDataRepository<TEntity>
                                                where TEntity : Center, new()
    {
        public CenterDataRepository(DbContext DbContext)
            : base(DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity))); }
        }
        public CenterDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity)));
        }
        public async Task<TEntity> GetByAddressAsync(string Address)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Address.Equals(Address));
        }
        public async Task<TEntity> GetByLoginIdAsync(string LoginId)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.LoginId.Equals(LoginId));
        }

        public async Task<List<TEntity>> GetToListByCountryCodeAsync(string CoutryCode)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CountryCode.Equals(CoutryCode)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCountryCodeWithRelatedAsync(string CoutryCode)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CountryCode.Equals(CoutryCode)).Include(entity => entity.ChangedUsers).
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

        public async Task<List<TEntity>> GetToListWithCenterIPAddressesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.CenterIPAddresses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCenterMacAddressesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.CenterMacAddresses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCenterRolesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.CenterRoles).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithCommoditiesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.Commodities).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithEStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.EStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithMStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.MStatuses).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListWithSStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.SStatuses).ToListAsync();
        }

        public async Task<bool> IsDuplecatedByNameAsync(TEntity tentity)
        {
            Center center = await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Name.Equals(tentity.Name));
            if (center == null)
            {
                return true;
            }
            return false;
        }
        public async Task<TEntity> GetByCenterWithStatusAsync(TEntity entity)
        {
            return await _DbContext.Set<TEntity>().Include(e => e.SStatuses).Include(e => e.MStatuses).Include(e => e.MStatuses).
                Include(e => e.Commodities).FirstOrDefaultAsync(e => e.Equals(entity));
        }

        public async Task<List<TEntity>> GetToListWithStatusesAsync()
        {
            return await _DbContext.Set<TEntity>().Include(e => e.SStatuses).Include(e => e.MStatuses).Include(e => e.EStatuses).Include(e => e.Commodities).ToListAsync();
        }
        public async Task<List<TEntity>> GetToListByUserIdWithRelatedAsync(string UserId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.UserId.Equals(UserId)).Include(e => e.SStatuses).
                Include(e => e.MStatuses).Include(e => e.EStatuses).Include(e => e.Commodities).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByLoginIdAsync(string LoginId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.LoginId.Equals(LoginId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByAddressAsync(string Address)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Address.Equals(Address)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByPhoneNumberAsync(string PhoneNumber)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.PhoneNumber.Equals(PhoneNumber)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCityAsync(string FaxNumber)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.FaxNumber.Equals(FaxNumber)).ToListAsync();
        }
    }
}