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

        Task<TEntity> ICenterDataRepository<TEntity>.GetByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByLoginIdAsync(string LoginId)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByAddressAsync(string Address)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByCountryCodeAsync(string CountryCode)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByPhoneNumberAsync(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByFaxnumberAsync(string Faxnumber)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByLoginIdAsync(string LoginId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByAddressAsync(string Address)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByCountryCodeAsync(string CoutryCode)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByPhoneNumberAsync(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByFaxnNumberAsync(string FaxNumber)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByIdWithRelatedAsync(string id)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByLoginIdWithRelatedAsync(string LoginId)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByAddressWithRelatedAsync(string Address)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByCountryCodeWithRelatedAsync(string CountryCode)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByPhoneNumberWithRelatedAsync(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> ICenterDataRepository<TEntity>.GetByFaxnumberWithRelatedAsync(string Faxnumber)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByCountryCodeWithRelatedAsync(string CoutryCode)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByUserIdWithRelatedAsync(string userId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByAddressWithRelatedAsync(string Address)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByPhoneNumberWithRelatedAsync(string PhoneNumber)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListByFaxNumberWithRelatedAsync(string FaxNumber)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListWithCommoditiesAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListWithEStatusesAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListWithMStatusesAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListWithSStatusesAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListWithStatusesAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListWithCenterMacAddressesAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListWithCenterIPAddressesAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> ICenterDataRepository<TEntity>.GetToListWithCenterRolesAsync()
        {
            throw new NotImplementedException();
        }
    }
}