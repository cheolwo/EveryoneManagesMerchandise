namespace PlatformManager.ofServices
{
    public class EntityNavigateFacgtory<TEntity> where TEntity : Entity, IRelationable
    {
        // 어떠한 페이지에서 이용되었느냐...
        // 어찌 됐든 Get으로 일단 이동하는 것으로 만든다.
        public static string GetPageofEntity()
        {
            return $"/Get/{Entity.GetRelationCode()}";
        }        
        public static string CreatePageofEntity()
        {
            return $"/Create/{Entity.CreateRelationCode()}";
        } 
        public static string UpdatePageofEntity()
        {
            return $"/Update/{Entity.UpdateRelationCode()}";
        } 
        public static string DeletePageofEntity()
        {
            return $"/Delete/{Entity.DeleteRelationCode()}";
        } 
    }
}