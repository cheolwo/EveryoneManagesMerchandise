using BusinessData;
using BusinessData.ofAccount.ofModel;
using BusinessData.ofGeneric.ofIdFactory;
using BusinessLogic.ofManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofManager.ofGeneric.ofFileFactory;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofGeneric
{
    public interface IDataManager
    {
        Type GetManagerType();
        void SetMangaerType(Type t);
    }
    // 값이 입력되면 형변환이 이루어지도록 하는 게 맞지.
    public interface IRescopeEntityManager
    {
        Task<Entity> CreateAsync(IdentityUser IdentityUser, Entity entity);
        Task<Entity> UpdateAsync(IdentityUser IdentityUser, Entity entity);
        Task<List<Entity>> GetToListAsync();
        Task DeleteByIdAsync(string Id);
        Type GetManagerType();
    }
    public interface IEntityManager<TEntity> where TEntity : Entity, IRelationable
    {
        Task<TEntity> CreateAsync(TEntity entity);
        Task<TEntity> CreateAsync(TEntity entity, List<IBrowserFile> Files, string connectionString);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity, List<IBrowserFile> Files);
        Task<List<TEntity>> GetToListAsync();
        Task DeleteByIdAsync(string Id);
        Dictionary<int, TEntity> ConvertToDic(List<TEntity> entities);
    }

    // 데이터 적합성 검사의 경우는 ApplicationLayer 단에서 해결해야될 문제야.
    public class DataManagerAttribute : Attribute
    {
        private readonly Type type;
        public DataManagerAttribute(Type T)
        {
            type = T;
        }
        public Type GetManagerType()
        {
            return type;
        }
    }
    public abstract class DataManager : IDataManager
    {
        private Type T;
        public DataManager(Type T)
        {
            this.T = T;
        }
        public Type GetManagerType()
        {
            return T;
        }
        public void SetMangaerType(Type t)
        {
            this.T = t;
        }
        // public Type Rescope(Entity entity)
        // {
        //     string RelationCode = entity.GetRelationCode();
            
        // }
    }
    public class EntityManager<TEntity> : IEntityManager<TEntity> where TEntity : Entity, IRelationable
    {
        protected readonly IEntityDataRepository<TEntity> _EntityDataRepository;
        protected readonly IEntityIdFactory<TEntity> _EntityIdFactory;
        protected readonly IEntityFileFactory<TEntity> _EntityFileFactory;
        protected readonly IEntityBlobStorage<TEntity> _entityBlobStorage;
        protected readonly DicConvertFactory<TEntity> _dicConvertFactory;

        public EntityManager(IEntityDataRepository<TEntity> EntityDataRepository,
                            IEntityIdFactory<TEntity> EntityIdFactory,
                            IEntityFileFactory<TEntity> entityFileFactory,
                            IEntityBlobStorage<TEntity> entityBlobStorage,
                            DicConvertFactory<TEntity> dicConvertFactory
                            )
        {
            _entityBlobStorage = entityBlobStorage;
            _EntityIdFactory = EntityIdFactory;
            _EntityDataRepository = EntityDataRepository;
            _EntityFileFactory = entityFileFactory;
            _dicConvertFactory = dicConvertFactory;
        }
        public virtual async Task<TEntity> CreateAsync(TEntity entity, List<IBrowserFile> files, string connectionString)
        {
            entity.Id = await _EntityIdFactory.CreateIdByRelationEntity(entity);
            entity.CreateTime = DateTime.Now;
            if(files.Count > 0)
            {
                TEntity BlobUploadEntity = await _entityBlobStorage.UploadAsync(entity, files, connectionString);
                return await _EntityDataRepository.AddAsync(BlobUploadEntity);
            }          
            return await _EntityDataRepository.AddAsync(entity);
        }
        public async Task<TEntity> UpdateAsync(TEntity entity, List<IBrowserFile> files, string connectionString)
        {
            TEntity BlobUploadEntity = await _entityBlobStorage.UploadAsync(entity, files, connectionString);
            return await _EntityDataRepository.UpdateAsync(BlobUploadEntity);
        }
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            return await _EntityDataRepository.UpdateAsync(entity);
        }
        public Dictionary<int, TEntity> ConvertToDic(List<TEntity> entities)
        {
            return _dicConvertFactory.ConvertToHashTable(entities);
        }

        public virtual async Task<TEntity> CreateAsync(TEntity entity)
        {
            entity.Id = await _EntityIdFactory.CreateIdByRelationEntity(entity);
            entity.CreateTime = DateTime.Now;
            return await _EntityDataRepository.AddAsync(entity);
        }

        public async Task DeleteByIdAsync(string Id)
        {
            TEntity entity = await _EntityDataRepository.GetByIdAsync(Id);
            await _EntityDataRepository.DeleteByIdAsync(Id);
        }

        public async Task<List<TEntity>> GetToListAsync()
        {
            return await _EntityDataRepository.GetToListAsync();
        }

        public Task<TEntity> CreateAsync(TEntity entity, List<IBrowserFile> Files)
        {
            throw new NotImplementedException();
        }

        public Task<TEntity> UpdateAsync(TEntity entity, List<IBrowserFile> Files)
        {
            throw new NotImplementedException();
        }
    }
}