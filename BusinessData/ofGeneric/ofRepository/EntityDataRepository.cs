using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessData
{
    public interface IEntityDataRepository<TEntity> where TEntity : Entity, IRelationable
    {
        // 기본
        Task<List<TEntity>> GetToListAsync();
        Task <TEntity> FirstOrDefaultAsync();
        Task<TEntity> AddAsync(TEntity tentity);
        Task<TEntity> UpdateAsync(TEntity tentity);
        Task DeleteByIdAsync(string Id);
        Task<TEntity> GetByIdAsync(string Id);
        Task<List<TEntity>> GetToListWithRelated();

        // 특정 By
        Task<TEntity> GetByUserAsync(IdentityUser identityUser);
        Task<List<TEntity>> GetToListByUserId(string UserId);
        Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser);
        Task<TEntity> GetByNameAsync(string Name);
        Task<TEntity> GetByContainerAsync(string containerName);
        Task<List<TEntity>> GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime);

        // By + With
        Task<TEntity> GetByIdWithChangedUsers(string Id);
        Task<TEntity> GetByIdWithImageofInfos(string Id);
        Task<TEntity> GetByIdWithDocs(string Id);
        Task<TEntity> GetByIdWithRelated(string Id);

        Task<int> GetCountAsync();
    }
    
    public class EntityDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : Entity, IRelationable, new()
    {
        protected DbContext _DbContext;
        private readonly TEntity entity = new();
        public EntityDataRepository(DbContext DbContext)
        {
            if (DbContext != null)
            {
                _DbContext = DbContext;
            }
            else { _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(), entity.GetDbConnetionString()); }
        }
        public EntityDataRepository()
        {
            _DbContext = (DbContext)Activator.CreateInstance(entity.GetDbContextType(), entity.GetDbConnetionString());
        }
        public async Task<TEntity> AddAsync(TEntity tentity)
        {
            try
            {
               await _DbContext.AddAsync(tentity);
               await _DbContext.SaveChangesAsync();
            }
            catch (DbUpdateException ex)
            {
               
            }
            finally
            {
               
            }
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

        public async Task<TEntity> GetByIdWithChangedUsers(string Id)
        {
            return await _DbContext.Set<TEntity>().Where(_ => _.Id == Id).Include(entity => entity.ChangedUsers).FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByIdWithImageofInfos(string Id)
        {
            return await _DbContext.Set<TEntity>().Where(_ => _.Id == Id).Include(entity=> entity.ImageofInfos).FirstOrDefaultAsync();
        }

        public async Task<TEntity> GetByIdWithDocs(string Id)
        {
            return await _DbContext.Set<TEntity>().Where(_ => _.Id == Id).Include(entity=> entity.Docs).FirstOrDefaultAsync();
        }

        public async Task<List<TEntity>> GetToListByUserId(string UserId)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.UserId.Equals(UserId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.UserId.Equals(IdentityUser.Id)).ToListAsync();
        }

        public async Task<TEntity> GetByIdWithRelated(string Id)
        {
            return await _DbContext.Set<TEntity>().Where(e=>e.UserId.Equals(Id)).Include(entity => entity.Docs).
                                                                                Include(entity => entity.ImageofInfos).
                                                                                Include(entity => entity.ChangedUsers).FirstOrDefaultAsync();
        }

        public async virtual Task<List<TEntity>> GetToListWithRelated()
        {
            return await _DbContext.Set<TEntity>().Include(entity => entity.ChangedUsers).
                                                    Include(entity => entity.Docs).
                                                    Include(entity => entity.ImageofInfos).ToListAsync();
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
    }
}