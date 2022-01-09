using BusinessData;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.ofManager.ofGeneric
{
    public interface INavigateFactory
    {
        string GetNavigateofAdd();
        string GetNavigateofDelte();
        string GetNavigateofUpdate();
        string GetNavigateofDetail();
    }

    public class NavigateFactory : INavigateFactory 
    {
        private readonly NavigationManager _navigationManager;
        public NavigateFactory(NavigationManager navigationManager)
        {
            _navigationManager = navigationManager;
        }

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
