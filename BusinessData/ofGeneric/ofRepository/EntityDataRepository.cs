using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessData
{
    public interface IEntityDataRepository<TEntity> where TEntity : Entity
    {
        // 기본
        Task<List<TEntity>> GetToListAsync();
        Task <TEntity> FirstOrDefaultAsync();
        Task<TEntity> AddAsync(TEntity tentity);
        Task<TEntity> UpdateAsync(TEntity tentity);
        Task DeleteByIdAsync(string Id);
        Task<TEntity> GetByIdAsync(string Id);
        Task AddEntitiesAsync(IList<TEntity> entities);
        Task AddEntitiesByAttachAsync(IList<TEntity> entities);
        Task UpdateAttachAsync(TEntity entity);

        // 특정 By
        Task<TEntity> GetByUserAsync(IdentityUser identityUser);
        Task<TEntity> GetByNameAsync(string Name);
        Task<TEntity> GetByContainerAsync(string containerName);
        Task<TEntity> GetByCodeAsync(string Code);
        Task<TEntity> GetByUserIdAsync(string UserId);
        Task<int> GetCountAsync();

        // GetToListBy
        Task<List<TEntity>> GetToListByUserIdAsync(string UserId);
        Task<List<TEntity>> GetToListBetweenStarnDateAndEndDateAsync(string Container);
        Task<List<TEntity>> GetToListByNameAsync(string Name);
        Task<List<TEntity>> GetToListByCodeAsync(string Code);
        Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser);
        Task<List<TEntity>> GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime);

        // GetByWith
        Task<TEntity> GetByUserWithRelatedAsync(IdentityUser identityUser);
        Task<TEntity> GetByNameWithRelatedAsync(string Name);
        Task<TEntity> GetByContainerWithRelatedAsync(string containerName);
        Task<TEntity> GetByCodeWithRelatedAsync(string Code);
        Task<TEntity> GetByUserIdWithRelatedAsync(string UserId);

        // GetToListByWith
        Task<List<TEntity>> GetToListByUserIdWithRelatedAsync(string UserId);
        Task<List<TEntity>> GetToListBetweenStarnDateAndEndDateWithRelatedAsync(string Container);
        Task<List<TEntity>> GetToListByNameWithRelatedAsync(string Name);
        Task<List<TEntity>> GetToListByCodeWithRelatedAsync(string Code);
        Task<List<TEntity>> GetToListByUserWithRelatedAsync(IdentityUser IdentityUser);
        Task<List<TEntity>> GetToListByBetweenDateTimeWithRelatedAsync(DateTime beforeDateTime, DateTime AfterDateTime);
    }
    
    public class EntityDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Entity, new()
    {
        protected DbContext _DbContext;
        protected readonly TEntity entity = new();
        public EntityDataRepository(DbContext DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity))); }
        }
        public EntityDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(typeof(TEntity)), entity.GetDbConnetionString(typeof(TEntity)));
        }
        public virtual async Task<TEntity> AddAsync(TEntity tentity)
        {
            await _DbContext.AddAsync(tentity);
            await _DbContext.SaveChangesAsync();
            return await GetByIdAsync(tentity.Id);
        }
        public async Task DeleteByIdAsync(string Id)
        {
            TEntity entity = await GetByIdAsync(Id);
            _DbContext.Remove(entity);
            await _DbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(string Id)
        {
            return await _DbContext.FindAsync<TEntity>(Id);
        }

        public async Task<int> GetCountAsync()
        {
            return await _DbContext.Set<TEntity>().CountAsync();
        }

        public async Task<List<TEntity>> GetToListAsync()
        {
            return await _DbContext.Set<TEntity>().ToListAsync();
        }
        public List<TEntity> GetToList()
        {
            return _DbContext.Set<TEntity>().ToList();
        }

        public async Task<TEntity> UpdateAsync(TEntity tentity)
        {
            _DbContext.Entry(tentity).CurrentValues.SetValues(tentity);
            await _DbContext.SaveChangesAsync();
            return await GetByIdAsync(tentity.Id);
        }
        public async Task<TEntity> GetByContainerAsync(string containerName)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.Container.Equals(containerName));
        }

        public async Task<List<TEntity>> GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CreateTime >= beforeDateTime && e.CreateTime <= AfterDateTime).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByUserIdAsync(string UserId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.UserId.Equals(UserId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.UserId.Equals(IdentityUser.Id)).ToListAsync();
        }

        public async Task<TEntity> GetByNameAsync(string Name)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.Name.Equals(Name));
        }

        public async Task<TEntity> GetByUserAsync(IdentityUser identityUser)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.UserId.Equals(identityUser.Id));
        }

        public async Task<TEntity> FirstOrDefaultAsync()
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByCodeAsync(string Code)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Code.Equals(Code));
        }

        public async Task AddEntitiesAsync(IList<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                entity.CreateTime = DateTime.Now;
                _DbContext.Set<TEntity>().Add(entity);
                await _DbContext.SaveChangesAsync();
            }
        }

        public async Task AddEntitiesByAttachAsync(IList<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                entity.CreateTime = DateTime.Now;
                var attach = _DbContext.Attach(entity);
                attach.State = EntityState.Modified;
                await _DbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAttachAsync(TEntity entity)
        {
            var attach = _DbContext.Attach(entity);
            attach.State = EntityState.Modified;
            await _DbContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetByUserIdAsync(string UserId)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.UserId.Equals(UserId)); 
        }

        public async Task<List<TEntity>> GetToListBetweenStarnDateAndEndDateAsync(DateTime StartDate, DateTime EndDate)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.CreateTime >= StartDate && e.CreateTime <= EndDate).ToListAsync();    
        }

        public async Task<List<TEntity>> GetToListBetweenStarnDateAndEndDateAsync(string Container)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Container.Equals(Container)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByNameAsync(string Name)
        {
            return await  _DbContext.Set<TEntity>().Where(e=>e.Name.Equals(Name)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCodeAsync(string Code)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.Code.Equals(Code)).ToListAsync(); 
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListAsync()
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.FirstOrDefaultAsync()
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.AddAsync(TEntity tentity)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.UpdateAsync(TEntity tentity)
        {
            throw new NotImplementedException();
        }

        Task IEntityDataRepository<TEntity>.DeleteByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByIdAsync(string Id)
        {
            throw new NotImplementedException();
        }

        Task IEntityDataRepository<TEntity>.AddEntitiesAsync(IList<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        Task IEntityDataRepository<TEntity>.AddEntitiesByAttachAsync(IList<TEntity> entities)
        {
            throw new NotImplementedException();
        }

        Task IEntityDataRepository<TEntity>.UpdateAttachAsync(TEntity entity)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByUserAsync(IdentityUser identityUser)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByNameAsync(string Name)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByContainerAsync(string containerName)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByCodeAsync(string Code)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByUserIdAsync(string UserId)
        {
            throw new NotImplementedException();
        }

        Task<int> IEntityDataRepository<TEntity>.GetCountAsync()
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByUserIdAsync(string UserId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListBetweenStarnDateAndEndDateAsync(string Container)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByNameAsync(string Name)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByCodeAsync(string Code)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByUserAsync(IdentityUser IdentityUser)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByUserWithRelatedAsync(IdentityUser identityUser)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByNameWithRelatedAsync(string Name)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByContainerWithRelatedAsync(string containerName)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByCodeWithRelatedAsync(string Code)
        {
            throw new NotImplementedException();
        }

        Task<TEntity> IEntityDataRepository<TEntity>.GetByUserIdWithRelatedAsync(string UserId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByUserIdWithRelatedAsync(string UserId)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListBetweenStarnDateAndEndDateWithRelatedAsync(string Container)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByNameWithRelatedAsync(string Name)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByCodeWithRelatedAsync(string Code)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByUserWithRelatedAsync(IdentityUser IdentityUser)
        {
            throw new NotImplementedException();
        }

        Task<List<TEntity>> IEntityDataRepository<TEntity>.GetToListByBetweenDateTimeWithRelatedAsync(DateTime beforeDateTime, DateTime AfterDateTime)
        {
            throw new NotImplementedException();
        }
    }
}