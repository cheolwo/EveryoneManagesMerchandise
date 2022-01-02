using BusinessData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofGeneric
{
    public interface INavigateFactory<TEntity> where TEntity : Entity
    {
        string GetNavigateofAdd();
        string GetNavigateofDelte();
        string GetNavigateofUpdate();
        string GetNavigateofDetail();
    }

    public class NavigateFactory<TEntity> : INavigateFactory<TEntity> where TEntity : Entity
    {
        public string GetNavigateofAdd()
        {
            throw new NotImplementedException();
        }

        public string GetNavigateofDelte()
        {
            throw new NotImplementedException();
        }

        public string GetNavigateofDetail()
        {
            throw new NotImplementedException();
        }

        public string GetNavigateofUpdate()
        {
            throw new NotImplementedException();
        }
    }
}
