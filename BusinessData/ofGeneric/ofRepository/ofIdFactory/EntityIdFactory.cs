using System.Text;
using System.Threading.Tasks;
using BusinessData;
using System;

namespace BusinessData.ofGeneric.ofIdFactory
{
    public interface IEntityIdFactory<TEntity> where TEntity : Entity, IRelationable
    {
        Task<string> CreateIdByRelationEntity(TEntity entity);
        Task<string> CreateAsync(TEntity entity);
    }

    public class EntityIdFactory<TEntity> : IEntityIdFactory<TEntity> where TEntity : Entity, IRelationable
    {
        protected readonly IEntityDataRepository<TEntity> _entityDataRepository;
        private int ChainingCode = 0;
        public EntityIdFactory(IEntityDataRepository<TEntity> entityDataRepository)
        {
            _entityDataRepository = entityDataRepository;
            
        }
        // 이거 하다가 Error 발생하면 쓰레드 부분에서 발생할 가능성이 있음.
        public virtual async Task<string> CreateAsync(TEntity entity)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(entity.GetRelationCode());
            stringBuilder.Append('-');
            int Count = await _entityDataRepository.GetCountAsync();
            stringBuilder.Append(Count);
            return stringBuilder.ToString();
        }
        public virtual async Task<string> CreateIdByRelationEntity(TEntity entity)
        {
            StringBuilder stringBuilder = new();
            stringBuilder.Append(entity.GetRelationCode());
            stringBuilder.Append('-');

            string dateTime = DateTime.Now.ToString("YY//MM/dd");
            string[] strs = dateTime.Split('-');

            foreach(var str in strs)
            {
                stringBuilder.Append(str);
            }
            stringBuilder.Append('-');
            int Count = await _entityDataRepository.GetCountAsync();
            stringBuilder.Append(Count);

            // Chaining Code
            stringBuilder.Append('-');
            stringBuilder.Append(ChainingCode);

            var CurrentEntity = await _entityDataRepository.GetByIdAsync(stringBuilder.ToString());
            if(CurrentEntity != null)
            {
                ChainingCode++;
                await CreateIdByRelationEntity(entity);
            }

            return stringBuilder.ToString();
        }    
    }
}