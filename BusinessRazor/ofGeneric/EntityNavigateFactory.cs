using BusinessData;

namespace BusinessRazor.ofGeneric
{
    public class EntityNavigateFactory<TEntity> where TEntity : Entity, IRelationable
    {
        // 어떠한 페이지에서 이용되었느냐...
        // 어찌 됐든 Get으로 일단 이동하는 것으로 만든다.
        public string GetPageofEntity(TEntity Entity)
        {
            return $"/Get/{Entity.GetRelationCode()}";
        }        
        public string CreatePageofEntity(TEntity Entity)
        {
            return $"/Create/{Entity.GetRelationCode()}";
        } 
        public string UpdatePageofEntity(TEntity Entity)
        {
            return $"/Update/{Entity.GetRelationCode()}";
        } 
        public string DeletePageofEntity(TEntity Entity)
        {
            return $"/Delete/{Entity.GetRelationCode()}";
        } 
    }
}