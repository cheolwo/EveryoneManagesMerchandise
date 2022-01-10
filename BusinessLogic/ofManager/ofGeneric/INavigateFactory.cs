using BusinessData;
using System;

namespace BusinessLogic.ofManager.ofGeneric
{
    public interface INavigateFactory<TEntity> where TEntity : Entity
    {
        string GetNavigateAfterAdd();
        string GetNavigateAfterDelte();
        string GetNavigateAfterUpdate();
    }

    public class NavigateFactory<TEntity> : INavigateFactory <TEntity> where TEntity : Entity
    {
        public NavigateFactory()
        {
        }

        public string GetNavigateAfterAdd()
        {
            throw new NotImplementedException();
        }

        public string GetNavigateAfterDelte()
        {
            throw new NotImplementedException();
        }

        public string GetNavigateAfterUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
