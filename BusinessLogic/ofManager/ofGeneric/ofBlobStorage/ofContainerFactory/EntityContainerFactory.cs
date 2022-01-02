using BusinessData;
using System;
using System.Text;
using System.Threading.Tasks;
namespace BusinessLogic.ofManager.ofGeneric.ofBlobStorage.ofContainerFactory
{
    public interface IEntityContainerFactory<TEntity> where TEntity : Entity, IRelationable
    {
        Task<string> CreateNameofContainer(TEntity entity);
    }

    public class EntityContainerFactory<TEntity> : IEntityContainerFactory<TEntity> where TEntity : Entity, IRelationable
    {
        private readonly IEntityDataRepository<TEntity> _entityDataRepository;
        public EntityContainerFactory(IEntityDataRepository<TEntity> entityDataRepository)
        {
            _entityDataRepository = entityDataRepository;
        }
        public StringBuilder stringBuilder = new ();
        private int ChainingCode = 0;

        public virtual async Task<string> CreateNameofContainer(TEntity entity)
        {
            stringBuilder.Append(entity.GetRelationCode()); // 1~4
            stringBuilder.Append(entity.UserId.ToLower());
            stringBuilder.Append('-');
            stringBuilder.Append(ChainingCode);
            string ContainerName = stringBuilder.ToString();

            var CurrentEntity = await _entityDataRepository.GetByContainerAsync(ContainerName);
            if(CurrentEntity != null)
            {
                ChainingCode++;
                await CreateNameofContainer(entity);
            }

            return ContainerName;
        }
    }
    public static class ContainerStringDigit
    {
        public const int UserId = 4;
        public const int HashCode = 8;
    }
}