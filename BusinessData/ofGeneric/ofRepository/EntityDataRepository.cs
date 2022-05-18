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
        Task AddEntities(IList<TEntity> entities);
        Task AddEntitiesByAttach(IList<TEntity> entities);
        Task UpdateAttachAsync(TEntity entity);
        // 특정 By
        Task<TEntity> GetByUserAsync(IdentityUser identityUser);
        Task<List<TEntity>> GetToListByUserId(string UserId);
        Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser);
        Task<TEntity> GetByNameAsync(string Name);
        Task<TEntity> GetByContainerAsync(string containerName);
        Task<List<TEntity>> GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime);
        Task<TEntity> GetByCodeAsync(string Code);
        Task<TEntity> GetByUserId(string UserId);
        Task<int> GetCountAsync();
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

        public async Task<List<TEntity>> GetToListByUserId(string UserId)
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

        public async Task AddEntities(IList<TEntity> entities)
        {
            foreach(var entity in entities)
            {
                entity.CreateTime = DateTime.Now;
                _DbContext.Set<TEntity>().Add(entity);
                await _DbContext.SaveChangesAsync();
            }
        }

        public async Task AddEntitiesByAttach(IList<TEntity> entities)
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

        public async Task<TEntity> GetByUserId(string UserId)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e=>e.UserId.Equals(UserId)); 
        }
    }
}