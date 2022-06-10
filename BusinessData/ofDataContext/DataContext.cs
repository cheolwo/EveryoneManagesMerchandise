using BusinessData.ofDataAccessLayer.ofCommon;
using BusinessData.ofDataAccessLayer.ofGeneric.ofIdFactory;
using BusinessData.ofDataAccessLayer.ofGeneric.ofRepository;
using BusinessLogic.ofEntityManager.ofGeneric.ofBlobStorage;
using BusinessLogic.ofEntityManager.ofGeneric.ofFileFactory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BusinessData.ofDataContext
{
    public class DataContextAttribute : Attribute
    {
        private Type t;
        public DataContextAttribute(Type type)
        {
            t = type;
        }
        public Type T
        {
            get => t;
        }
    }
    public abstract class DataContext
    {
        protected EntityManagerBuilder entityManagerBuilder = new();
        public DataContext()
        {
            OnConfigureEntityBlobStorage(entityManagerBuilder);
            OnConfigureEntityFile(entityManagerBuilder);
            OnConfigureEntityId(entityManagerBuilder);
            OnConfigureEntityRepository(entityManagerBuilder);
        }
        protected abstract void OnConfigureEntityId(EntityManagerBuilder entityManagerBuilder);
        protected abstract void OnConfigureEntityFile(EntityManagerBuilder entityManagerBuilder);
        protected abstract void OnConfigureEntityBlobStorage(EntityManagerBuilder entityManagerBuilder);
        protected abstract void OnConfigureEntityRepository(EntityManagerBuilder entityManagerBuilder);

        public abstract Task<T> PostAsync<T>(T t) where T : Entity;
        public abstract Task<T> PutAsync<T>(T t) where T : Entity;
        public abstract Task<T> GetByIdAsync<T>(string id) where T : Entity;
        public abstract Task DeleteByIdAsync<T>(string id) where T : Entity;
        public abstract Task<IEnumerable<T>> GetsAsync<T>() where T : Entity;
    }
    public class EntityManagerBuilder
    {
        private Dictionary<string, IEntityDataRepository> DicEntityDataRepository = new();
        private Dictionary<string, IEntityIdFactory> DicEntityIdFactory = new();
        private Dictionary<string, IEntityBlobStorage> DicEntityBlobStorage = new();
        private Dictionary<string, IEntityFileFactory> DicEntityFileFactory = new();
        public virtual void ApplyEntityRepositoryServiceConfiguration(string nameofEntityDataRepository, IEntityDataRepository entityDataRepository)
        {
            DicEntityDataRepository.Add(nameofEntityDataRepository, entityDataRepository);
        }
        public virtual void ApplyEntityIdFactory(string nameofEntityIdFactory, IEntityIdFactory entityIdFactory) 
        {
            DicEntityIdFactory.Add(nameofEntityIdFactory, entityIdFactory);
        }
        public virtual void ApplyEntityFileFactory(string nameofEntityFileFactory, IEntityFileFactory entityFileFactory) 
        {
            DicEntityFileFactory.Add(nameofEntityFileFactory, entityFileFactory);
        }
        public virtual void ApplysEntityBlobStorage(string nameofEntityBlobStorage, IEntityBlobStorage entityBlobStorage)
        {
            DicEntityBlobStorage.Add(nameofEntityBlobStorage, entityBlobStorage);
        }
        public IEntityDataRepository GetEntityDataRepository(string name)
        {
            return DicEntityDataRepository[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityIdFactory GetEntityIdFactory(string name)
        {
            return DicEntityIdFactory[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityBlobStorage GetEntityBlobStorage(string name)
        {
            return DicEntityBlobStorage[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
        public IEntityFileFactory GetEntityFileFactory(string name)
        {
            return DicEntityFileFactory[name]
                   ?? throw new ArgumentNullException("Not Included");
        }
    }
    public interface IEntityIdConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityIdBuilder<TEntity> builder);
    }
    public interface IEntityFileConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityFileBuilder<TEntity> builder);
    }
    public interface IEntityBlobConfiguration<TEntity> where TEntity : Entity
    {
        void Configure(EntityBlobStorageBuilder<TEntity> builder);
    }
    public class EntityIdConfiguration<TEntity> : IEntityIdConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityIdBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityFileConfiguration<TEntity> : IEntityFileConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityFileBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityBlobStorageConfiguration<TEntity> : IEntityBlobConfiguration<TEntity> where TEntity : Entity
    {
        public void Configure(EntityBlobStorageBuilder<TEntity> builder)
        {
            throw new NotImplementedException();
        }
    }
    public class EntityIdBuilder<TEntity> where TEntity : Entity
    {
        
    }
    public class EntityFileBuilder<TEntity> where TEntity : Entity
    {

    }
    public class EntityBlobStorageBuilder<TEntity> where TEntity : Entity
    {

    }
}
