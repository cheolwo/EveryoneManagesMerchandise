using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessData.ofDataAccessLayer.ofCommon;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BusinessData.ofDataAccessLayer.ofGeneric.ofRepository
{
    public interface IEntityDataRepository<TEntity> where TEntity : Entity
    {
        // 기본
        Task<List<TEntity>> GetToListAsync();
        Task<TEntity> FirstOrDefaultAsync();
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
        Task<List<TEntity>> GetToListByContainerAsync(string Container);
        Task<List<TEntity>> GetToListByNameAsync(string Name);
        Task<List<TEntity>> GetToListByCodeAsync(string Code);
        Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser);
        Task<List<TEntity>> GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime);
        Task<List<TEntity>> GetToListByCreateTimeAsync(DateTime dateTime);
    }

    public class EntityDataRepository<TEntity> : IEntityDataRepository<TEntity> where TEntity : class
    {
        protected DbContext _DbContext;
        protected DbContext _InMemoryDbContext;
        public virtual async Task<TEntity> AddAsync(TEntity tentity)
        {
            await _DbContext.AddAsync(tentity);
            await _DbContext.SaveChangesAsync();
            TEntity entity = await _DbContext.FindAsync<TEntity>(tentity.Id);
            if (entity != null)
            {
                _InMemoryDbContext.AddAsync<TEntity>(entity);
            }
            return entity;
        }
        public async Task<TEntity> GetByIdAsync(string Id)
        {
            TEntity InMemoryEntity = _InMemoryDbContext.FindAsync<TEntity>(Id);
            if (InMemoryEntity != null)
            {
                return InMemoryEntity;
            }
            var DbEntity = await _DbContext.FindAsync<TEntity>(Id);
            if (DbEntity != null)
            {
                return DbEntity;
            }
            throw new ArgumentNullException("Not Exist");
        }
        public async Task DeleteByIdAsync(string Id)
        {
            TEntity entity = await GetByIdAsync(Id);
            _DbContext.Remove(entity);
            await _DbContext.SaveChangesAsync();
        }
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
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Container.Equals(containerName));
        }

        public async Task<List<TEntity>> GetToListByBetweenDateTimeAsync(DateTime beforeDateTime, DateTime AfterDateTime)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CreateTime >= beforeDateTime && e.CreateTime <= AfterDateTime).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByUserIdAsync(string UserId)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.UserId.Equals(UserId)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByUserAsync(IdentityUser IdentityUser)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.UserId.Equals(IdentityUser.Id)).ToListAsync();
        }

        public async Task<TEntity> GetByNameAsync(string Name)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.Name.Equals(Name));
        }

        public async Task<TEntity> GetByUserAsync(IdentityUser identityUser)
        {
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.UserId.Equals(identityUser.Id));
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
            foreach (var entity in entities)
            {
                entity.CreateTime = DateTime.Now;
                _DbContext.Set<TEntity>().Add(entity);
                await _DbContext.SaveChangesAsync();
            }
        }

        public async Task AddEntitiesByAttachAsync(IList<TEntity> entities)
        {
            foreach (var entity in entities)
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
            return await _DbContext.Set<TEntity>().FirstOrDefaultAsync(e => e.UserId.Equals(UserId));
        }

        public async Task<List<TEntity>> GetToListBetweenStarnDateAndEndDateAsync(DateTime StartDate, DateTime EndDate)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.CreateTime >= StartDate && e.CreateTime <= EndDate).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListBetweenStarnDateAndEndDateAsync(string Container)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Container.Equals(Container)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByNameAsync(string Name)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Name.Equals(Name)).ToListAsync();
        }

        public async Task<List<TEntity>> GetToListByCodeAsync(string Code)
        {
            return await _DbContext.Set<TEntity>().Where(e => e.Code.Equals(Code)).ToListAsync();
        }

        public Task<List<TEntity>> GetToListByContainerAsync(string Container)
        {
            throw new NotImplementedException();
        }

        public Task<List<TEntity>> GetToListByCreateTimeAsync(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
