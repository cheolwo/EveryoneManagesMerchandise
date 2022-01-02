using BusinessData;

namespace BusinessLogic.ofManager.ofGeneric.ofFileFactory
{
    public interface IEntityFileFactory<TEntity> where TEntity : Entity
    {

    }
    public class EntityFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Entity
    {

    }
    public interface ICommodityFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Entity
    {

    }
    public class CommodityFileFactory<TEntity> : EntityFileFactory<TEntity>, ICommodityFileFactory<TEntity> where TEntity : Commodity
    {

    }
    public interface ICenterFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Center
    {

    }
    public class CenterFileFactory<TEntity> : EntityFileFactory<TEntity>, ICenterFileFactory<TEntity> where TEntity : Center
    {

    }
    public interface IStatusFileFactory<TEntity> : IEntityFileFactory<TEntity> where TEntity : Status
    {

    }
    public class StatusFileFactory<TEntity> : EntityFileFactory<TEntity>, IStatusFileFactory<TEntity> where TEntity : Status
    {

    }
}